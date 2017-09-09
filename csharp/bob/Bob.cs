using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        if(statement == statement.ToUpper() && Regex.IsMatch(statement,@"[a-zA-Z]")){
            return "Whoa, chill out!";
        }else if(statement.EndsWith("?")){
            return "Sure.";
        }else if (statement == ""){
            return "Fine. Be that way!";
        }
       
        return "Whatever.";
    }
}