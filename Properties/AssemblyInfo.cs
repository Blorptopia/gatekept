using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(Gatekept.BuildInfo.Description)]
[assembly: AssemblyDescription(Gatekept.BuildInfo.Description)]
[assembly: AssemblyCompany(Gatekept.BuildInfo.Company)]
[assembly: AssemblyProduct(Gatekept.BuildInfo.Name)]
[assembly: AssemblyCopyright(Gatekept.BuildInfo.Author + " 2026")]
[assembly: AssemblyTrademark(Gatekept.BuildInfo.Company)]
[assembly: AssemblyVersion(Gatekept.BuildInfo.Version)]
[assembly: AssemblyFileVersion(Gatekept.BuildInfo.Version)]
[assembly: MelonInfo(typeof(Gatekept.Gatekept), Gatekept.BuildInfo.Name, Gatekept.BuildInfo.Version, Gatekept.BuildInfo.Author, Gatekept.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]
