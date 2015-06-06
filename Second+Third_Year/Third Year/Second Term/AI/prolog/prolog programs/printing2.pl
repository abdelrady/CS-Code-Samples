print1(0).
print1(N):-
	M is N-1,
	print1(M),
	write(N),
 	nl.