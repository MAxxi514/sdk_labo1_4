namespace LibrairieConversionNote
{
    public class ConversionAlphabetiqueToNote
    {
        public string Transformer(string note) { 
        
if (note == "A")

            {
             return "LA"; 
            }
if (note == "B")
            {
                return "SI";
            }
if (note == "C")
            {
                return "DO";
            }
if (note == "D")
            {
                return "RE";
            }
if (note == "E")
            {
                return "MI";
            }
if (note == "F")
            {
                return "FA";
            }
if (note == "G")
            {
                return "SOL";
            }
else return "Erreur, entrer une lettre entre A et G";
        }
    }
}