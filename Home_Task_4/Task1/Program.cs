using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;


namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> engText = new List<string>()
            {
                "I live in a house near the mountains. I have two brothers and one (test 1) sister, and I was ",
                "born last. My father teaches mathematics, and my mother is a nurse at a big hospital. My ",
                "brothers are very smart and work hard in school. My sister is a (test 2) nervous girl, but ",
                "she is very kind. My grandmother also lives with us. She came from Italy when I was two ",
                "years old. She has grown old, but she is still very strong. She cooks the (test 3) best food! ",
                "My family is very important to me. We do lots of things together. My brothers and I like ",
                "to go on long walks in the mountains. My sister likes to (test 4) cook with my ",
                "grandmother. On the weekends we all play board games together. We laugh and always ",
                "have a good time. I love my family very much."
            };


            List<string> uaText = new List<string>()
            {
                "Я живу в будинку біля гір. У мене два брати і одна (тест 1) сестра, і я народився ",
                "останнім. Мій батько викладає математику, а мама працює медсестрою у великій ",
                "лікарні. Мої брати дуже розумні і старанно вчаться в школі. Моя сестра (тест 2) ",
                "нервова дівчина, але вона дуже добра. Моя бабуся також живе з нами. Вона ",
                "готує (тест 3) найкращу їжу!",
                "Моя сім'я дуже важлива для мене. Ми багато чого робимо разом. Ми з братами",
                "любимо ходити на довгі прогулянки в гори. Моя сестра любить (тест 4) готувати з ",
                "моєю бабусею. На вихідних ми всі разом граємо в настільні ігри. Ми сміємося і ",
                "завжди добре проводимо час. Я дуже люблю свою сім'ю."
            };
            List<string> res1 = QuotesFinder.FindSentencesWithQuotes(engText);
            List<string> res2 = QuotesFinder.FindSentencesWithQuotes(uaText);

            Renderer.RenderList(res1);
            Renderer.RenderList(res2);

        }
    }
}