# EditorConfig playground

This project is essentially a test project for playing and configuring the
 .editorconfig file (<https://editorconfig.org/)>

It uses configuration for .Net projets (Visual Studio (2019) / Visual Studio Code)



## Ressources

Custom editor settings
<https://docs.microsoft.com/en-us/visualstudio/ide/create-portable-custom-editor-options?view=vs-2019>



## .Net coding conventions

Reference site
<https://docs.microsoft.com/en-us/visualstudio/ide/editorconfig-code-style-settings-reference?view=vs-2019>



## .Net naming conventions

Reference site
<https://docs.microsoft.com/en-us/visualstudio/ide/editorconfig-naming-conventions?view=vs-2019>

Naming conventions should be ordered from **most specific to least specific**
 in the .editorconfig file. The first rule encountered that can be applied is
 the only rule that is applied.

For each **naming convention**, you must specify the **symbols** it applies to,
 a **naming style**, and a **severity** for enforcing the convention, using
 the properties described below.


Properties                                                          | Possible values
--------------------------------------------------------------------|--------------------------------------------------------------------
dotnet_naming_rule.{namingRuleTitle}.severity                       | none or silent, suggestion, warning, error
dotnet_naming_rule.{namingRuleTitle}.symbols                        | {symbolTitle} (see table below)
dotnet_naming_rule.{namingRuleTitle}.style                          | {styleTitle} (see table below)

To create a **symbol** for your naming convention, you can specify (any or all):

Rule                                                                | Possible values
--------------------------------------------------------------------|--------------------------------------------------------------------
dotnet_naming_symbols.{symbolTitle}.applicable_accessibilities      | &ast;, public, internal (or friend), private, protected, protected_internal (or protected_friend), private_protected, local
dotnet_naming_symbols.{symbolTitle}.applicable_kinds                | &ast;, namespace, class, struct, interface, enum, property, method, field, event, delegate, parameter, type_parameter, local, local_function
dotnet_naming_symbols.{symbolTitle}.required_modifiers              | abstract (or must_inherit), async, const, readonly, static (or shared)

To create a **style** for your naming convention, you can specify (any or all):

Rule                                                                | Possible values
--------------------------------------------------------------------|--------------------------------------------------------------------
dotnet_naming_style.{styleTitle}.capitalization                     | pascal_case, camel_case, first_word_upper, all_upper, all_lower
dotnet_naming_style.{styleTitle}.required_prefix                    | "string of your desired prefix"
dotnet_naming_style.{styleTitle}.required_suffix                    | "string of your desired suffix"
dotnet_naming_style.{styleTitle}.word_separator                     | "string of your desired word separator"



## Credits and inspiration projects

- <https://github.com/dotnet/roslyn/blob/master/.editorconfig>
- <https://github.com/django/django/blob/master/.editorconfig>
- <https://github.com/nunit/nunit/blob/master/.editorconfig>
