print1(0).
print1(N):-
	write(N),
	nl,
	M is N-1,
	print1(M).