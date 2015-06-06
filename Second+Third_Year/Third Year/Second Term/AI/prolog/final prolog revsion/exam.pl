a:-
	write('a1 '),\+b,!,c,\+d.
a:-
	write('a2 '),b,e.
b:-
	write('b1 '),fail.
b:-
	write('b2 '),fail.
c:-
	write('c1 '),fail.
c:-
	write('c2 ').
d:-
	fail.
e.