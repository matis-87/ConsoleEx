using System;
using System.Text;

namespace MyConsoleEx
{
    static public class ConsoleEx
    {
        static public void WriteLine(string sender, string text, ConsoleColor color = ConsoleColor.Gray, params object[] param)
        {
                String time = DateTime.Now.ToString("HH:mm:ss");
                StringBuilder st = new StringBuilder(sender + "> ");
                st.Append("[" + time + "] ");
                st.Append(text);
                Console.WriteLine("");
                Console.ForegroundColor = color;
                Console.WriteLine(st.ToString(), param);
                Console.ResetColor();
        }

    }
}
