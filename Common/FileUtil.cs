using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Common
{
    public class FileUtil
    {/// <summary>
    /// 过滤字符串
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
       public static string Filter(string input)
        {
            if (input==null)
            {
                return null;
            }
            string pattern = @"*";
            if (Regex.Match(input, Regex.Escape(pattern), RegexOptions.Compiled | RegexOptions.IgnoreCase).Success) throw new Exception("字符串中含有非法字符！");
            string output=input.Replace(" ' ","");
            return output;
        }
    }
}
