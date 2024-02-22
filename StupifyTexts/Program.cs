using TextCopy;

Random rnd = new Random();
var jimmyfiedText = string.Empty;
var i = 0;
while (true)
{
    Console.Write("Enter Input: ");
    var input = Console.ReadLine();

    if (input == string.Empty)
    {
        Console.WriteLine("Empty Input.");
        continue;
    }

    foreach (var letter in input.ToLower())
    {
        if (letter == 'a')
        {
            modifyLetterA();
        }
        else if (letter == 'b')
        {
            modifyLetterB();
        }
        else if (letter == 'c')
        {
            modifyLetterC();
        }
        else if (letter == 'd')
        {
            modifyLetterD();
        }
        else if (letter == 'e')
        {
            modifyLetterE();
        }
        else if (letter == 'f')
        {
            modifyLetterF();
        }
        else if (letter == 'g')
        {
            modifyLetterG();
        }
        else if (letter == 'h')
        {
            modifyLetterH();
        }
        else if (letter == 'i')
        {
            modifyLetterI();
        }
        else if (letter == 'j')
        {
            modifyLetterJ();
        }
        else if (letter == 'k')
        {
            modifyLetterK();
        }
        else if (letter == 'l')
        {
            modifyLetterL();
        }
        else if (letter == 'm')
        {
            modifyLetterM();
        }
        else if (letter == 'n')
        {
            modifyLetterN();
        }
        else if (letter == 'o')
        {
            modifyLetterO();
        }
        else if (letter == 'p')
        {
            modifyLetterP();
        }
        else if (letter == 'q')
        {
            modifyLetterQ();
        }
        else if (letter == 'r')
        {
            modifyLetterR();
        }
        else if (letter == 's')
        {
            modifyLetterS();
        }
        else if (letter == 't')
        {
            modifyLetterT();
        }
        else if (letter == 'u')
        {
            modifyLetterU();
        }
        else if (letter == 'v')
        {
            modifyLetterV();
        }
        else if (letter == 'w')
        {
            modifyLetterW();
        }
        else if (letter == 'x')
        {
            modifyLetterX();
        }
        else if (letter == 'y')
        {
            modifyLetterY();
        }
        else if (letter == 'z')
        {
            modifyLetterZ();
        }
        else if (letter == ' ')
        {
            modifySpace();
        }
        else if (letter == '?')
        {
            modifyQuestionMark();
        }
        else if (letter == '!')
        {
            modifyExclamationMark();
        }
        else
        {
            jimmyfiedText += letter;
        }
    }
    Console.WriteLine(jimmyfiedText);
    ClipboardService.SetText(jimmyfiedText);
    jimmyfiedText = string.Empty;
}



void modifyLetterA()
{
    i = rnd.Next(7);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'å';
            break;
        case 1:
            jimmyfiedText += 'ä';
            break;
        case 2:
            jimmyfiedText += 'ã';
            break;
        case 3:
            jimmyfiedText += 'á';
            break;
        case 4:
            jimmyfiedText += 'à';
            break;
        case 5:
            jimmyfiedText += 'ɑ';
            break;
        case 6:
            jimmyfiedText += '@';
            break;
    }
}

void modifyLetterB()
{
    i = rnd.Next(6);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'ḃ';
            break;
        case 1:
            jimmyfiedText += 'ƀ';
            break;
        case 2:
            jimmyfiedText += 'Ƃ';
            break;
        case 3:
            jimmyfiedText += 'ƃ';
            break;
        case 4:
            jimmyfiedText += 'ß';
            break;
        case 5:
            jimmyfiedText += 'Ꞗ';
            break;
    }
}

void modifyLetterC()
{
    i = rnd.Next(6);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'Č';
            break;
        case 1:
            jimmyfiedText += 'ĉ';
            break;
        case 2:
            jimmyfiedText += 'ꞓ';
            break;
        case 3:
            jimmyfiedText += 'Ç';
            break;
        case 4:
            jimmyfiedText += 'ç';
            break;
        case 5:
            jimmyfiedText += 'ȼ';
            break;
    }
}

void modifyLetterD()
{
    i = rnd.Next(5);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'đ';
            break;
        case 1:
            jimmyfiedText += 'ɖ';
            break;
        case 2:
            jimmyfiedText += 'Ɖ';
            break;
        case 3:
            jimmyfiedText += 'ȡ';
            break;
        case 4:
            jimmyfiedText += 'ᶑ';
            break;
    }
}

void modifyLetterE()
{
    i = rnd.Next(8);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'э';
            break;
        case 1:
            jimmyfiedText += 'ë';
            break;
        case 2:
            jimmyfiedText += 'è';
            break;
        case 3:
            jimmyfiedText += 'é';
            break;
        case 4:
            jimmyfiedText += 'ḝ';
            break;
        case 5:
            jimmyfiedText += 'ḗ';
            break;
        case 6:
            jimmyfiedText += 'ẽ';
            break;
        case 7:
            jimmyfiedText += 'ê';
            break;
    }
}

void modifyLetterF()
{
    i = rnd.Next(3);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'f';
            break;
        case 1:
            jimmyfiedText += 'ꞙ';
            break;
        case 2:
            jimmyfiedText += 'Ꞙ';
            break;
    }
}

void modifyLetterG()
{
    i = rnd.Next(5);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'g';
            break;
        case 1:
            jimmyfiedText += '⅁';
            break;
        case 2:
            jimmyfiedText += '₲';
            break;
        case 3:
            jimmyfiedText += 'ℊ';
            break;
        case 4:
            jimmyfiedText += 'ğ';
            break;
    }
}

void modifyLetterH()
{
    i = rnd.Next(4);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'Ƕ';
            break;
        case 1:
            jimmyfiedText += 'Ħ';
            break;
        case 2:
            jimmyfiedText += 'ɦ';
            break;
        case 3:
            jimmyfiedText += 'ḧ';
            break;
    }
}

void modifyLetterI()
{
    i = rnd.Next(5);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'ï';
            break;
        case 1:
            jimmyfiedText += 'î';
            break;
        case 2:
            jimmyfiedText += 'ɨ';
            break;
        case 3:
            jimmyfiedText += 'į';
            break;
        case 4:
            jimmyfiedText += 'i';
            break;
    }
}

void modifyLetterJ()
{
    i = rnd.Next(4);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'ĵ';
            break;
        case 1:
            jimmyfiedText += 'ⅉ';
            break;
        case 2:
            jimmyfiedText += 'j';
            break;
        case 3:
            jimmyfiedText += 'ʝ';
            break;
    }
}

void modifyLetterK()
{
    i = rnd.Next(6);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'ĸ';
            break;
        case 1:
            jimmyfiedText += 'Ⓚ';
            break;
        case 2:
            jimmyfiedText += 'ᵏ';
            break;
        case 3:
            jimmyfiedText += 'ʞ';
            break;
        case 4:
            jimmyfiedText += 'Ķ';
            break;
        case 5:
            jimmyfiedText += 'қ';
            break; 
    }
}

void modifyLetterL()
{
    i = rnd.Next(5);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'ℒ';
            break;
        case 1:
            jimmyfiedText += 'L';
            break;
        case 2:
            jimmyfiedText += 'l';
            break;
        case 3:
            jimmyfiedText += 'Ḹ';
            break;
        case 4:
            jimmyfiedText += 'ĺ';
            break;
    }
}

void modifyLetterM()
{
    i = rnd.Next(6);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'ⓜ';
            break;
        case 1:
            jimmyfiedText += 'സ';
            break;
        case 2:
            jimmyfiedText += 'ɱ';
            break;
        case 3:
            jimmyfiedText += 'ᴍ';
            break;
        case 4:
            jimmyfiedText += 'ᵐ';
            break;
        case 5:
            jimmyfiedText += '₥';
            break;
    }
}

void modifyLetterN()
{
    i = rnd.Next(6);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'ⓝ';
            break;
        case 1:
            jimmyfiedText += 'η';
            break;
        case 2:
            jimmyfiedText += 'ℵ';
            break;
        case 3:
            jimmyfiedText += '₦';
            break;
        case 4:
            jimmyfiedText += 'Ŋ';
            break;
        case 5:
            jimmyfiedText += 'ᾖ';
            break;
    }
}

void modifyLetterO()
{
    i = rnd.Next(8);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'Ⓞ';
            break;
        case 1:
            jimmyfiedText += 'ö';
            break;
        case 2:
            jimmyfiedText += 'õ';
            break;
        case 3:
            jimmyfiedText += 'ō';
            break;
        case 4:
            jimmyfiedText += 'Ø';
            break;
        case 5:
            jimmyfiedText += 'Ꝋ';
            break;
        case 6:
            jimmyfiedText += 'ꝍ';
            break;
        case 7:
            jimmyfiedText += 'ꝋ';
            break;
    }
}

void modifyLetterP()
{
    i = rnd.Next(10);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'ⓟ';
            break;
        case 1:
            jimmyfiedText += '℘';
            break;
        case 2:
            jimmyfiedText += 'Ꝓ';
            break;
        case 3:
            jimmyfiedText += 'ꝓ';
            break;
        case 4:
            jimmyfiedText += 'Ꝑ';
            break;
        case 5:
            jimmyfiedText += '₱';
            break;
        case 6:
            jimmyfiedText += '¶';
            break;
        case 7:
            jimmyfiedText += 'ℙ';
            break;
        case 8:
            jimmyfiedText += 'þ';
            break;
        case 9:
            jimmyfiedText += 'p';
            break;
    }
}

void modifyLetterQ()
{
    i = rnd.Next(6);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'ʠ';
            break;
        case 1:
            jimmyfiedText += 'Ɋ';
            break;
        case 2:
            jimmyfiedText += 'ҩ';
            break;
        case 3:
            jimmyfiedText += 'Ϙ';
            break;
        case 4:
            jimmyfiedText += 'q';
            break;
        case 5:
            jimmyfiedText += 'ⓠ';
            break;
    }
}

void modifyLetterR()
{
    i = rnd.Next(6);
    switch (i)
    {
        case 0:
            jimmyfiedText += '℟';
            break;
        case 1:
            jimmyfiedText += 'ɾ';
            break;
        case 2:
            jimmyfiedText += 'ṝ';
            break;
        case 3:
            jimmyfiedText += 'Ի';
            break;
        case 4:
            jimmyfiedText += 'ℛ';
            break;
        case 5:
            jimmyfiedText += 'ℜ';
            break;
    }
}

void modifyLetterS()
{
    i = rnd.Next(6);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'Ƨ';
            break;
        case 1:
            jimmyfiedText += 'ƨ';
            break;
        case 2:
            jimmyfiedText += 'Ϩ';
            break;
        case 3:
            jimmyfiedText += 'Ꞩ';
            break;
        case 4:
            jimmyfiedText += '$';
            break;
        case 5:
            jimmyfiedText += '§';
            break;
    }
}

void modifyLetterT()
{
    i = rnd.Next(6);
    switch (i)
    {
        case 0:
            jimmyfiedText += '┴';
            break;
        case 1:
            jimmyfiedText += '₮';
            break;
        case 2:
            jimmyfiedText += 'ⓣ';
            break;
        case 3:
            jimmyfiedText += 'ŧ';
            break;
        case 4:
            jimmyfiedText += 'т';
            break;
        case 5:
            jimmyfiedText += 'ẗ';
            break;
    }
}

void modifyLetterU()
{
    i = rnd.Next(6);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'Ʉ';
            break;
        case 1:
            jimmyfiedText += 'Ʊ';
            break;
        case 2:
            jimmyfiedText += 'ū';
            break;
        case 3:
            jimmyfiedText += 'ṳ';
            break;
        case 4:
            jimmyfiedText += 'ư';
            break;
        case 5:
            jimmyfiedText += 'ụ';
            break;
    }
}

void modifyLetterV()
{
    i = rnd.Next(6);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'Ꝟ';
            break;
        case 1:
            jimmyfiedText += 'ṽ';
            break;
        case 2:
            jimmyfiedText += 'Ṽ';
            break;
        case 3:
            jimmyfiedText += 'ʌ';
            break;
        case 4:
            jimmyfiedText += '⊻';
            break;
        case 5:
            jimmyfiedText += '⊽';
            break;
    }
}

void modifyLetterW()
{
    i = rnd.Next(4);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'ധ';
            break;
        case 1:
            jimmyfiedText += 'ʷ';
            break;
        case 2:
            jimmyfiedText += 'ẅ';
            break;
        case 3:
            jimmyfiedText += '₩';
            break;
    }
}

void modifyLetterX()
{
    i = rnd.Next(6);
    switch (i)
    {
        case 0:
            jimmyfiedText += '✖';
            break;
        case 1:
            jimmyfiedText += 'ᕽ';
            break;
        case 2:
            jimmyfiedText += '✗';
            break;
        case 3:
            jimmyfiedText += 'ᚷ';
            break;
        case 4:
            jimmyfiedText += 'X';
            break;
        case 5:
            jimmyfiedText += 'x';
            break;
    }
}

void modifyLetterY()
{
    i = rnd.Next(7);
    switch (i)
    {
        case 0:
            jimmyfiedText += '¥';
            break;
        case 1:
            jimmyfiedText += 'ɏ';
            break;
        case 2:
            jimmyfiedText += 'γ';
            break;
        case 3:
            jimmyfiedText += 'ʎ';
            break;
        case 4:
            jimmyfiedText += 'ｙ';
            break;
        case 5:
            jimmyfiedText += 'ㄚ';
            break;
        case 6:
            jimmyfiedText += 'Ῠ';
            break;
    }
}

void modifyLetterZ()
{
    i = rnd.Next(8);
    switch (i)
    {
        case 0:
            jimmyfiedText += 'Ƶ';
            break;
        case 1:
            jimmyfiedText += 'Ɀ';
            break;
        case 2:
            jimmyfiedText += 'ʐ';
            break;
        case 3:
            jimmyfiedText += 'ƶ';
            break;
        case 4:
            jimmyfiedText += 'ꙁ';
            break;
        case 5:
            jimmyfiedText += '☡';
            break;
        case 6:
            jimmyfiedText += '之';
            break;
        case 7:
            jimmyfiedText += '乙';
            break;
    }
}

void modifyQuestionMark()
{
    i = rnd.Next(6);
    switch (i)
    {
        case 0:
            jimmyfiedText += '?';
            break;
        case 1:
            jimmyfiedText += '¿';
            break;
        case 2:
            jimmyfiedText += '؟';
            break;
        case 3:
            jimmyfiedText += '⸮';
            break;
        case 4:
            jimmyfiedText += 'ʔ';
            break;
        case 5:
            jimmyfiedText += '⁇';
            break;
    }
}

void modifySpace()
{
    i = rnd.Next(2);
    switch (i)
    {
        case 0:
            jimmyfiedText += ' ';
            jimmyfiedText += ' ';
            break;
        case 1:
            jimmyfiedText += ' ';
            jimmyfiedText += ' ';
            jimmyfiedText += ' ';
            break;
    }
}

void modifyExclamationMark()
{
    i = rnd.Next(3);
    switch (i)
    {
        case 0:
            jimmyfiedText += '!';
            break;
        case 1:
            jimmyfiedText += '﹗';
            break;
        case 2:
            jimmyfiedText += '¡';
            break;
    }
}