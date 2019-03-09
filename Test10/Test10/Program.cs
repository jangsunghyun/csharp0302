using System;

namespace AttributeTest
{
    [AdditionalinfoAttribute("홍길동", "2018/10/1", Download = "http://ojc.asia")]
    class Test
    {
        static void Main()
        {
            Type type = typeof(Test);
            foreach (Attribute attr in type.GetCustomAttributes(true))
            {
                AdditionalinfoAttribute info = attr as AdditionalinfoAttribute;
                if (info != null)
                    Console.WriteLine("Name={0}, Update Date={1}," +
                        "Download={2}",
                        info.Name, info.Update, info.Download);
            }
        }
    }
}