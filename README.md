
![CSHARP](https://img.shields.io/badge/Language-CSHARP-boldgreen?style=for-the-badge&logo=csharp)
![Download](https://img.shields.io/github/downloads/K3rnel-Dev/HellSing-Binder/total?style=for-the-badge)
![Releases](https://img.shields.io/github/v/release/K3rnel-Dev/HellSing-Binder?style=for-the-badge)

<p >
  <img src="banner.png" alt="Project Banner" />
</p>

# 🛠️ File Merger & Encryption Tool

This project is a file merger and encryption tool that combines two executable files into one using XOR encryption and embeds them into a stub. The stub is then compiled by a builder. When executed, the stub decrypts the two resources and extracts them to the disk location specified by the user in the builder options.

---

### > **[⬇️ Download for Windows](https://github.com/K3rnel-Dev/HellSing-Binder/releases/tag/Builds)**

---

## ✨ Features

- 🔐 **XOR Encryption:** Converts two executable files into ciphertext by applying XOR encryption.
- 📦 **Stub Resource Embedding:** The builder embeds two encrypted resources into the stub, which is compiled and executed later.
- 💾 **File Extraction:** The stub decrypts and drops the two files to a location of the user's choice.
- ⚙️ **Flexible Configuration:**
  - 👁️ **HideFiles:** Option to hide the dropped files.
  - 🗑️ **Self-Delete:** Automatically deletes the stub after it completes its task.
  - 🤖 **Basic Obfuscation:** A simple obfuscation technique to make the code harder to analyze.

---

## 📚 Dependencies

To build this project, you need the following dependencies:

- **MetroFramework** - A .NET WinForms framework used for the UI.  
  [Download MetroFramework](https://github.com/thielj/MetroFramework)
  
- **dnlib** - A library to work with .NET assemblies for obfuscation purposes.  
  [Download dnlib](https://github.com/0xd4d/dnlib)

Make sure to install these libraries before building the project.

---

## 🚀 Usage

### Builder Configuration
1. Add the two executable files that you want to merge.
2. Select the options you need:
   - 👁️ **HideFiles:** Hide the extracted files after dropping them.
   - 🗑️ **Self-Delete:** Automatically delete the stub after execution.
   - 🤖 **Obfuscate:** Apply basic obfuscation to the build file.
3. Compile the stub with the embedded encrypted-files.

### Execution
Once the stub is executed:
- It decrypts the embedded files.
- Extracts them to the specified disk location.
- Executes any optional features (hide files, self-delete).

---

## 📸 Screenshots

> ![](./1.png)
> ![](./2.png)

---

## ⚠️ Disclaimer

**This tool is created for educational purposes only.**  
Any misuse of this project for malicious purposes is strictly prohibited.  
The author is not responsible for any illegal use or damages caused by this tool.

---

## ⚙️ Credits

- **MetroFramework**  
  [MetroFramework on GitHub](https://github.com/thielj/MetroFramework)

- **dnlib**  
  [dnlib on GitHub](https://github.com/0xd4d/dnlib)
