using System.Security.Cryptography;
using System.Text;


namespace HOTP
{
    class HashFunction
    {
        public static string SHA1(string text)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            //Вычисление хэш-значение для заданного массива байтов
            //Кодировка все символов строки в последовательность байтов
            sha1.ComputeHash(Encoding.ASCII.GetBytes(text));
            //Получение значение вычисленного хэш-кода в байтах.
            byte[] hash = sha1.Hash;
            //Изменяемая строка символов
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                //Добавление в сроку в 16-ичном формате
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
        public static int HMACHSHA1(string key)
        {
            //Создание объекта класса HMACSHA1 с помощью ключа
            HMACSHA1 hmacsha1 = new HMACSHA1(Encoding.ASCII.GetBytes(key));
            byte[] hmac_result = hmacsha1.ComputeHash(GetBytes(counter++));
            int offset = hmac_result[19] & 0xf;
            int bin_code = (hmac_result[offset] & 0x7f) << 24
            | (hmac_result[offset + 1] & 0xff) << 16
            | (hmac_result[offset + 2] & 0xff) << 8
            | (hmac_result[offset + 3] & 0xff);
            //Сохранить только первые 6 знаков пароля
            int hotp = bin_code % 1000000;
            return hotp;
        }
        //8-байтовый счётчик
        public static long counter = 0L;
        //Изменение счётчика
        private static byte[] GetBytes(long counter)
        {
            byte[] res = new byte[8];
            for (int i = res.Length - 1; i > -1; i--)
            { 
                res[i] = (byte) (counter & 0xff);
                counter >>= 8;
            }
            return res;
        }
    }
}
