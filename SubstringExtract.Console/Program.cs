/// <summary>
///     Extracts a substring string between two specified substrings from a string, ignoring the first and last whitespace
/// </summary>
/// <param name="logMessage">the original string</param>
/// <param name="keyWord1">First substring</param>
/// <param name="keyWord2">Second substring</param>
/// <returns></returns>
/*public*/ static string ExtractSubstringFromALogMessage(string logMessage, string keyWord1, string keyWord2)
{
    var positionOfCropping = logMessage.IndexOf(keyWord1, StringComparison.InvariantCulture);
    var substring = logMessage.Substring(positionOfCropping + keyWord1.Length);
    substring = substring.TrimStart();
    positionOfCropping = substring.IndexOf(keyWord2, StringComparison.InvariantCulture);
    substring = substring.Substring(0, positionOfCropping);
    return substring.TrimEnd();
}

//https://learn.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-visual-studio?tabs=netcore-cli
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(ExtractSubstringFromALogMessage("1x 2 3w", "1","3"));
Console.WriteLine(ExtractSubstringFromALogMessage("between one and two.", "one", "two"));
Console.WriteLine(ExtractSubstringFromALogMessage("one and two.", "one", "two"));