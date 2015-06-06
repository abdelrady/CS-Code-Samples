head([H|T],H).
tail([H|T],T).
palindrome([H],L).
palindrome([H|T],L):-
	palindrome(T,L),
	head(T,H1),
	head(L,H2),
	H1 = H2.