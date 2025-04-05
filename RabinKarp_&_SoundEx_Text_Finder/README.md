# Rabin-Karp & SoundEx Algorithms for Text Searching

This project implements two popular algorithms **Rabin-Karp** and **SoundEx** for text searching and pattern matching in C# using Windows Forms.

## Features

- **File Loading**: You can load any `.txt` file to search within.
- **Pattern Search**: Input a pattern and select an algorithm to search for its occurrences.
- **Algorithm Options**:
  - **Rabin-Karp**: A popular algorithm used for string matching, particularly effective for searching a pattern in large texts.
  - **SoundEx**: A phonetic algorithm that is used for indexing names by sound, as pronounced in English.
- **Text Highlighting**: The application will highlight all occurrences of the pattern in the text.
- **Navigation**: Use the "Up" and "Down" buttons to scroll through the different occurrences in the text.


## Algorithms

### Rabin-Karp Algorithm

The Rabin-Karp algorithm is a pattern searching algorithm that uses hashing to find any one of a set of pattern strings in a text. It is particularly efficient when searching for multiple patterns in a text.

### SoundEx Algorithm

The SoundEx algorithm is a phonetic algorithm for indexing names by sound, as pronounced in English. It is mainly used for matching names that sound similar but may be spelled differently.


## Texts Folder

In the repository, there's a **`Texts`** folder that contains several text files. These files are provided so you can try the program and test the pattern searching functionality. Simply load any of these files into the application and search for patterns using the available algorithms.




