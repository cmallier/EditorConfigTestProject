# EditorConfig playground

This project is essentially a test project for playing and configuring the .editorconfig file (https://editorconfig.org/)


It uses configuration for .Net projets (Visual Studio (2019) / Visual Studio Code)


## Ressources

Custom editor settings
https://docs.microsoft.com/en-us/visualstudio/ide/create-portable-custom-editor-options?view=vs-2019


## .Net coding conventions

Reference site
https://docs.microsoft.com/en-us/visualstudio/ide/editorconfig-code-style-settings-reference?view=vs-2019



## .Net naming conventions

Reference site
https://docs.microsoft.com/en-us/visualstudio/ide/editorconfig-naming-conventions?view=vs-2019


Naming conventions should be ordered from **most specific to least specific** in the .editorconfig file. The first rule encountered that can be applied is the only rule that is applied.

For each **naming convention**, you must specify the **symbols** it applies to, a **naming style**, and a **severity** for enforcing the convention, using the properties described below.

<table>
    <caption>Naming convention</caption>
    <tr>
        <td>Properties<td>
        <td>&nbsp;<td>
    </tr>
    <tr>
        <td>dotnet_naming_rule.{namingRuleTitle}.severity<td>
        <td>none or silent, suggestion, warning, error<td>
    </tr>
    <tr>
        <td>dotnet_naming_rule.{namingRuleTitle}.symbols<td>
        <td>{symbolTitle} (see table below)<td>
    </tr>
    <tr>
        <td>dotnet_naming_rule.{namingRuleTitle}.style <td>
        <td>{styleTitle} (see table below)<td>
    </tr>
</table>


To create a **symbol** for your naming convention, you can specify (any or all):
<table>
    <caption>Symbols</caption>
    <tr>
        <td>Rule<td>
        <td>Possible values<td>
    </tr>
    <tr>
        <td>dotnet_naming_symbols.{symbolTitle}.applicable_accessibilities<td>
        <td>*, public, internal (or friend), private, protected, protected_internal (or protected_friend), private_protected, local<td>
    </tr>
    <tr>
        <td>dotnet_naming_symbols.{symbolTitle}.applicable_kinds<td>
        <td>*, namespace, class, struct, interface, enum, property, method, field, event, delegate, parameter, type_parameter, local, local_function<td>
    </tr>
    <tr>
        <td>dotnet_naming_symbols.{symbolTitle}.required_modifiers<td>
        <td>abstract (or must_inherit), async, const, readonly, static (or shared)<td>
    </tr>
</table>

To create a **style** for your naming convention, you can specify (any or all):
<table>
    <caption>Style</caption>
    <tr>
        <td>Rule<td>
        <td>Possible values<td>
    </tr>
    <tr>
        <td>dotnet_naming_style.{styleTitle}.capitalization<td>
        <td>pascal_case, camel_case, first_word_upper, all_upper, all_lower<td>
    </tr>
    <tr>
        <td>dotnet_naming_style.{styleTitle}.required_prefix<td>
        <td>"string of your desired prefix"<td>
    </tr>
    <tr>
        <td>dotnet_naming_style.{styleTitle}.required_suffix<td>
        <td>"string of your desired suffix"<td>
    </tr>
    <tr>
        <td>dotnet_naming_style.{styleTitle}.word_separator<td>
        <td>"string of your desired word separator"<td>
    </tr>
</table>


## Credits and inspiration projects

- https://github.com/dotnet/roslyn/blob/master/.editorconfig
- https://github.com/symfony/symfony/blob/master/.editorconfig
- https://github.com/django/django/blob/master/.editorconfig
- https://github.com/nunit/nunit/blob/master/.editorconfig



