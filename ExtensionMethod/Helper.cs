namespace ExtensionMethod
{
    public static class Helper
    {
        public static string TransformFirstCharacter(this string value) 
        {
            if (value.Count() <= 0)
                return "";
            //char firstCharacter = value[0];
            //if (firstCharacter >= 65 && firstCharacter <= 90)
            //{
            //    firstCharacter = (char)(firstCharacter + 32);
            //    return value.Replace(value[0], firstCharacter);
            //}
            //else if (firstCharacter >= 97 && firstCharacter <= 122)
            //{
            //    firstCharacter = (char)(firstCharacter - 32);
            //    return value.Replace(value[0], firstCharacter);
            //}
            //else
            //{
            //    return value;
            //}
            char[] inputCharacters = value.ToCharArray();
            inputCharacters[0] = char.IsUpper(inputCharacters[0]) ? char.ToLower(inputCharacters[0]) : char.ToUpper(inputCharacters[0]);
            return new string(inputCharacters);
        }
    }
}
