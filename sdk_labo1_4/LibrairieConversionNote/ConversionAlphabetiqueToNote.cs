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


///« ALPHA» => Note vers alphabétique

﻿namespace LibrairieConversionNote
{
    public class ConversionAlphabetiqueToNote
    {
        public string Transformer(string Alpha) { 
        
if (Alpha == "LA")

            {
             return "A"; 
            }
if (Alpha == "SI")
            {
                return "B";
            }
if (Alpha == "DO")
            {
                return "C";
            }
if (Alpha == "RE")
            {
                return "D";
            }
if (Alpha == "MI")
            {
                return "E";
            }
if (Alpha == "FA")
            {
                return "F";
            }
if (Alpha == "SOL")
            {
                return "G";
            }
else return "Erreur, entrer une lettre entre A et G";
        }
    }
}
