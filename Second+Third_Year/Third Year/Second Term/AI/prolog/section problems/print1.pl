% print the number from n to 1
print1(0).    % base case
print1(N):-
	write(N),
	nl,
	M is N-1,
	print1(M).