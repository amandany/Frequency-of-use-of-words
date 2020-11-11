#Generator of a diagram of the relative frequency of words in the text.

The column of words and dots must be separated by a single space.
The word column must have a width equal to the length of the longest word, and
shorter words are right-aligned (that is,
the required number of underscores (_) is written before them when output).
The point column has a maximum width of 10 characters. 10 points correspond to the frequency of
occurrence of the most frequent word. The frequency of occurrence of other words is considered
relative to this value. Rounding is performed according to the rules of mathematics, and
values of the form INTEGER + 0.5 are rounded up.
The list of words should be ordered from the rarest to the most frequent.


Input:
aa aa bbb bbb bbb bbb bbb c c c c c c c c c
Output:
_aa ..
bbb ......
__c ..........

Input:
aa c c c c c c c c c c c c c c c c c c c c c c c c c c c
Output:
aa
_c ..........

Input:
aa aa aa aa aa bbb bbb bbb bbb c c c c c c c c c c c c c c c
Output:
bbb ...
_aa ...
__c ..........