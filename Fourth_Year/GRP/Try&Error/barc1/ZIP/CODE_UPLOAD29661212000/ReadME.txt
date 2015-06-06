[BARCODE HISTORY]

     Let's begin with a little history. Universal Product Code
(UPC) was adopted for commercial use by the grocery industry in
the USA. Among the advantages were a rapid, accurate and reliable
way of entering stock information into a computer and the
possibility to sack a lot of workers and to do more profit. The
early success led to the development of the European Article
Numbering System (EAN), a symbology similar to UPC, that is
widely used in Europe and in the rest of the World. I'll teach
you to crack this one, since I do not -fortunately- live in the
States. Keep in mind, anyway, that there are different barcode
symbologies, each with its own particular pattern of bars. The
UPC/EAN code used on retail products is an all-numeric code; so
is the Interleaved 2 of 5 Code. Code 39 includes upper case
letters, digits, and a few symbols. Code 128 includes every
printable and unprintable ASCII character code. The most new one
is a 2-D code. These are special rectangular codes, called
stacked barcodes or matrix codes. They can store considerably
more information than a standard barcode. They require special
readers which cost more than a standard scanner. The practical
limit for a standard barcode depends on a number of factors, but
20 to 25 characters is an approximate maximum. For applications
that need more data, matrix codes are used. For example, the next
time you receive a package from United Parcel Service look for
a small square label with a pattern of dots and a small bullseye
in the centre. This is a MaxiCode label, and it is used by UPS
for automatic destination sortition.

     The manufacturer's ID number on the barcode uniquely
identifies products. These numbers are managed by the Uniform
Code Council in Dayton, Ohio for the States and Canada and by the
EAN authority (Internationale Article Numbering Association) in
Bruxelles, for Europe and the rest of the World. The
manufacturer's ID number accounts for some digits of the code,
which leaves other digits to be assigned in any way the producer
wants. He provides retail outlets with a list of his products and
their assigned codes so that they can be entered in the cash
register system. Many codes are NOT on the products and are added
by the supermarkets on the fly, using an internal code schema
that may be non standard. Now it's enough... let's crack.

     BARCODES are the only thing an automated casher needs to see
on a product to calculate its price and automatically catalogate
the sold merchandise... imagine (just imagine it :=) coz it would
be extremely illegal to act in this way) somebody would fasten
an adhesive home-made codebar label direct on the top of the
supermarket/mall/retail store label, say on a bottle of Pomerol
(that's a very good but unfortunately very expensive french
wine).

     The new label would mean for the casher something like
"cheap wine from Bordeaux, France, cost so and so, everything
it's OK, do not worry"... do you think that anybody would come
to the idea that there is something wrong with the label, with
the bottle or with you? I have been codebaring for years and had
only once a problem, coz my printer was running out of ink and
the scanner in the supermarket could not read it... so what? Act
uninterested, always wear jackets of the utmost quality, shetland
pullovers and beautiful expensive shoes... (all articles that you
may codebar too, by the way), in this society appearance and look
count much more than substance and knowledge... LET'S USE THIS
TO OUR ADVANTAGE! Nobody will ever come to the idea that you may
actually really know the working of the scheme... coz codebar is
pretty complicated and not exactly exceptionally public. On the
Web there are a lot information about it, but most of them are
useless, unless you know how to search most of the time you'll
find only sentences like this one:

          "The calculated check digit is the twelfth and final
          digit in the U.P.C.code. It is calculated based on a
          specific algorithm, and is necessary to ensure that
          the number is read or key-entered correctly."


[THE 13 BAR "CODES"]

Each barcode label has 13 values, from #0 to #12 (that's the EAN
code, the UPC american one has only 12, from #0 to #11).
     #0 and #1 indicate the origin of the product.
     #2 to #11 give the article code
     #12 (the last and 13th one) is a checksum value, that
     verifies the validity of all the other numbers.
How is it calculated? #12 is calculated in 4 steps
     VALUE A:  You sum odd position numbers (#0+#2+#4+#6+#8+#10)
     VALUE B:  You sum even position numbers and multiply by 3
               ((#1+#3+#5+#7+#9+#11)*3)
     VALUE C:  You sum value A and value B
     VALUE D:  You mod value C (you divide by 10 and only keep
     the remaining units, a very widespread checking scheme)

     If the result is not zero, you subtract it from 10.
Now look at a barcode label, get some books or other barcoded
items and *watch* it...

Bar codes are supposed to have "quiet zones" on either side of
the symbol. Quiet zones are blank areas, free of any printing or
marks,typically 10 times the width of the narrowest bar or space
in the bar code. Failure to allow adequate space on either side
of the symbol for quiet zones can make it impossible to read the
bar code.

On the barcode there are two "borders", left and right, and a
"middle" longer line. These three lines are longer than the
others and are used to "regulate" the scanner to whatever
dimension has been used for the barcode.
#0 dwells left of the first (left) border and has a special
meaning, the other 12 numbers are written "inside" the code and
are divided in two "groups" by the middle bar.
Each value is coded through SEVEN bars: black=1 and White=0.
These form two couples of "optic" bars of different widths.
We come now to the "magic" part: In order to bluff the
simpletons, barcode uses three different SETS of characters to
represent the values 0-9. This should make it impossible for you
to understand what's going on, as usual, in this society, slaves
should not need to worry with the real functioning of things.
   Here are the graphic codes of the three graphic sets:

     CODE A            CODE B (XOR C)    CODE C (NOT A)
0:  0001101   (13)     0100111   (39)    1110010   (114)
1:  0011001   (25)     0110011   (51)    1100110   (102)
2:  0010011   (19)     0011011   (27)    1101100   (108)
3:  0111101   (61)     0100001   (33)    1000010   (066)
4:  0100011   (35)     0011101   (29)    1011100   (092)
5:  0110001   (49)     0111001   (57)    1001110   (078)
6:  0101111   (47)     0000101   (05)    1010000   (080)
7:  0111011   (59)     0010001   (17)    1000100   (068)
8:  0110111   (55)     0001001   (09)    1001000   (072)

9:  0001011   (11)     0010111   (23)    1110100   (116)

Borders:       101
Centre:        01010

- The C graphic set is a "NOT A" graphic set.
- The B graphic set is a "XOR C" graphic set.
- each value has two couples of bars with different widths

 Now watch some labels yourself... see the difference between the
numbers left and the numbers right? The first "half" of the
barcode is coded using sets A and B, the second "half" using set
C. As if that were not enough, A and B are used inside the first
"half" in a combination that varies and depends from value #0,
following 10 different patterns:

              #1   #2   #3   #4   #5  #6
   0          A    A    A    A    A    A
   1          A    A    B    A    B    B
   2          A    A    B    B    A    B
   3          A    A    B    B    B    A
   4          A    B    A    A    B    B
   5          A    B    B    A    A    B
   6          A    B    B    B    A    A
   7          A    B    A    B    A    B
   8          A    B    A    B    B    A
   9          A    B    B    A    B    A

"Ah! Stupid buyer will never understand why the same values gives
different bars! Nothing is as reliable as barcodes!" :=)

Let's take as example the codebar for Martini Dry:
BARCODE:    8 0 00570 00425 7
Let's see: we have a 8 0 0 = booze
Then a 000570 as ABABBA and a 004257 as C
"Even" sum: 8+0+5+0+0+2 = 15 (even sum)
Then a 0+0+7+0+4+5= 16 and 16 *3 = 48 (odd sum)
Then a 15+48=63
63 === 3
10 - 3 = 7 = checksum
Pattern = 8 = ABABBA CCCCCC

OK, one more example: Osborne Windows programming series Volume
2 General purpose API functions (always here on my table)...
BARCODE: 9 7 80078 81991 9
Let's see: we have a 9 7 8 = book
Then a 780078 as ABBABA and a 819919 as C
"Even" sum: 9+8+0+8+1+9 = 35 (odd sum)
Then a 7+0+7+8+9+1= 32 and 32 * 3 = 96 (even sum)
Then a 35+96=131
131 === 1
10 - 1 = 9 = checksum
Pattern = 9 = ABBABA

Well... what's the point of all this?
The point, is that who DOES NOT KNOW is taken along
on a boat ride, who KNOWS and LEARNS can use his knowledge in
order to try to beat blue and black the loathsome consumistic
oligarchy where we are compelled to live. Try it out for
yourself... if you crack correctly and wisely your supermarket,
mall and library bills will be cut to almost zero.  (Just kidding!)

