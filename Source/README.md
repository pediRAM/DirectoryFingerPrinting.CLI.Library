
![logo](https://raw.githubusercontent.com/pediRAM/DirectoryFingerPrinting.CLI.Library/main/Documentation/icon.png)

[![License: GPL v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![Release](https://img.shields.io/github/release/pediRAM/DirectoryFingerPrinting.CLI.Library.svg?sort=semver)](https://github.com/pediRAM/DirectoryFingerPrinting.CLI.Library/releases)
[![NuGet](https://img.shields.io/nuget/v/DirectoryFingerPrinting.CLI.Library)](https://www.nuget.org/packages/DirectoryFingerPrinting.CLI.Library)


# DirectoryFingerPrinting.CLI.Library
This library provides types and methods for parsing specific arguments used by "DirectoryFingerPrinting.CLI" (dfp.exe), comparing two file-metadata, exporting reports in CSV, JSON or XML, help text etc., which are used by the cli application "dpf.exe" and you can find in my other repository "DirectoryFingerPrinting.CLI".

## Parameters
Following parameters are currently parsed, recognized and in use:

| Parameter                      | Examples (using short names)                                          |
|--------------------------------|-----------------------------------------------------------------------|
| --assemblies-only              | dfp -ao --directory .\                                                |
| --directory                    | dfp --directory .\                                                    |
| --ignore-timestamps            | dfp -its -d .\                                                        |
| --ignore-size                  | dfp -is -d .\                                                         |
| --ignore-creation-date         | dfp -icd -d .\                                                        |
| --ignore-last-modification     | dfp -ilm -d .\                                                        |
| --ignore-last-access           | dfp -ila -d .\                                                        |
| --ignore-version               | dfp -iv -d .\                                                         |
| --ignore-checksum              | dfp -ics -d .\                                                        |
| --ignore-hidden-files          | dfp -ihf -d .\                                                        |
| --ignore-access-errors         | dfp -iae -d .\                                                        |
| --ignore-case                  | dfp -ic -d .\                                                         |
| --recursive                    | dfp -r -d .\                                                          |
| --positive-list                | dfp -p -d .\ -x "json,txt,xml,yaml"                                   |
| --negative-list                | dfp -n -d .\ -x "log,md" -ihf                                         |
| --extensions                   | dfp -x "json,txt,xml,yaml" -d .\                                      |
| --use-crc32                    | dfp -crc32 -d .\                                                      |
| --use-md5                      | dfp -md5 -d .\                                                        |
| --use-sha1                     | dfp -d .\ -sha1                                                       |
| --use-sha256                   | dfp -d .\ -sha256                                                     |
| --use-sha512                   | dfp -d .\ -sha512                                                     |
| --report-essential             | dfp -re -d .\                                                         |
| --report-informative           | dfp -ri -d .\                                                         |
| --report-verbose               | dfp -rv -d .\                                                         |
| --print-colored                | dfp -pc -d .\                                                         |
| --no-header                    | dfp -nh -d .\                                                         |
| --no-format                    | dfp -nf -d .\                                                         |
| --print-sorted-ascendent       | dfp -asc -d .\                                                        |
| --print-sorted-descendent      | dfp -desc -d .\                                                       |
| --print-only-filename          | dfp -pof -d .\                                                        |
| --save                         | dfp -s "C:\MyDFP Files\Test" -d "C:\MyDir" --recursive                |
| --format-dfp                   | dfp -dfp "C:\MyDFP Files\Test" -d "C:\MyDir" -r                       |
| --format-xml                   | dfp -xml "C:\MyDFP Files\Test" -d "C:\MyDir" -r                       |
| --format-json                  | dfp -json "C:\MyDFP Files\Test" -d "C:\MyDir" -r                      |
| --format-csv                   | dfp -csv "C:\MyDFP Files\Test" -d "C:\MyDir" -r                       |
| --compare-directories          | dfp -cd "C:\MyDir1" "C:\MyDir2"                                       |
| --compare-fingerprints         | dfp -cf "temp\fingerprint1.dfp" "temp\fingerprint2.json"              |
| --compare                      | dfp -c "temp\fingerprint.dfp" "C:\MyDir"                              |
| --use-color                    | dfp -pc -d .\                                                         |
| --load-options                 | dfp -lo "options.txt" -d .\                                           |
| --save-options                 | dfp -so "options.txt" -d .\                                           |
| --versions                     | dfp --versions                                                        |
| --checksums                    | dfp --checksums                                                       |
| --sizes                        | dfp --sizes                                                           |
| --help                         | dfp -h                                                                |
| --version                      | dfp -v                                                                |

## Examples for using parameters

| Parameter (long name)          | Examples (using short name)                                           |
|--------------------------------|-----------------------------------------------------------------------|
| --assemblies-only              | dfp -ao --directory C:\myDir                                          |
| --directory                    | dfp -d "C:\My Personal Directory"                                     |
| --ignore-timestamps            | dfp -its -d .\                                                        |
| --ignore-size                  | dfp -is -d ..\                                                        |
| --ignore-creation-date         | dfp -icd -d .\                                                        |
| --ignore-last-modification     | dfp -ilm -d .\                                                        |
| --ignore-last-access           | dfp -ila -d .\                                                        |
| --ignore-version               | dfp -iv -d .\                                                         |
| --ignore-checksum              | dfp -ics -d .\                                                        |
| --ignore-hidden-files          | dfp -ihf -d .\                                                        |
| --ignore-access-errors         | dfp -iae -d .\                                                        |
| --ignore-case                  | dfp -ic -d .\                                                         |
| --recursive                    | dfp -r -d .\                                                          |
| --positive-list                | dfp -p -d .\ -x "json,txt,xml,yaml"                                   |
| --negative-list                | dfp -n -d .\ -x "log,md" -ihf                                         |
| --extensions                   | dfp -x "json,txt,xml,yaml" -d .\                                      |
| --use-crc32                    | dfp -crc32 -d .\                                                      |
| --use-md5                      | dfp -md5 -d .\                                                        |
| --use-sha1                     | dfp -d .\ -sha1                                                       |
| --use-sha256                   | dfp -d .\ -sha256                                                     |
| --use-sha512                   | dfp -d .\ -sha512                                                     |
| --report-essential             | dfp -re -d .\                                                         |
| --report-informative           | dfp -ri -d .\                                                         |
| --report-verbose               | dfp -rv -d .\                                                         |
| --print-colored                | dfp -pc -d .\                                                         |
| --no-header                    | dfp -nh -d .\                                                         |
| --no-format                    | dfp -nf -d .\                                                         |
| --print-sorted-ascendent       | dfp -asc -d .\                                                        |
| --print-sorted-descendent      | dfp -desc -d .\                                                       |
| --print-only-filename          | dfp -pof -d .\                                                        |
| --save                         | dfp -s "C:\MyDFP Files\Test" -d "C:\MyDir" --recursive                |
| --format-dfp                   | dfp -dfp "C:\MyDFP Files\Test" -d "C:\MyDir" -r                       |
| --format-xml                   | dfp -xml "C:\MyDFP Files\Test" -d "C:\MyDir" -r                       |
| --format-json                  | dfp -json "C:\MyDFP Files\Test" -d "C:\MyDir" -r                      |
| --format-csv                   | dfp -csv "C:\MyDFP Files\Test" -d "C:\MyDir" -r                       |
| --compare-directories          | dfp -cd "C:\MyDir1" "C:\MyDir2"                                       |
| --compare-fingerprints         | dfp -cf "temp\fingerprint1.dfp" "temp\fingerprint2.json"              |
| --compare                      | dfp -c "temp\fingerprint.dfp" "C:\MyDir"                              |
| --use-color                    | dfp -pc -d .\                                                         |
| --load-options                 | dfp -lo "options.txt" -d .\                                           |
| --save-options                 | dfp -so "options.txt" -d .\                                           |
| --versions                     | dfp --versions                                                        |
| --checksums                    | dfp --checksums                                                       |
| --sizes                        | dfp --sizes                                                           |
| --help                         | dfp -h                                                                |
| --version                      | dfp -v                                                                |


## Error codes
Following error codes (integer) are returned after cli executable has terminated.
You can output them in prompt/cmd by:

```cmd
echo %errorlevel%
```

| Error Code | Description                                                    |
|------------|----------------------------------------------------------------|
| 0          | OK (no error).                                                 |
| 1          | No parameters.                                                 |
| 2          | Missing parameter.                                             |
| 3          | Unknown parameter.                                             |
| 4          | Internal error.                                                |
| 5          | Illegal value.                                                 |
| 6          | Single parameter.                                              |
| 7          | File already exists.                                           |
| 8          | Writing fingerprint file failed.                               |
| 9          | File not found.                                                |
| 10         | Directory not found.                                           |
| 11         | Calculate, save, and compare at once are not provided.         |
| 12         | Illegal/Unknown fingerprint file extension.                    |
| 13         | Unequal hashsum algorithms.                                    |
