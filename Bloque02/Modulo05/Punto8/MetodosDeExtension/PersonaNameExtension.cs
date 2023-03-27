namespace MetodosDeExtension
{
    public static class PersonaNameExtension
    {
        public static string ToUpperFisrtLetter(this string data)
        {
            if (data.Length > 0)
            {
                string[] elements = data.Split(' ');
                data = string.Empty;
                for (int i = 0; i < elements.Length; i++)
                {
                    data += elements[i].Substring(0, 1).ToUpper() + elements[i].Substring(1) + " ";
                }
            }
            return data;
        }
    }
}