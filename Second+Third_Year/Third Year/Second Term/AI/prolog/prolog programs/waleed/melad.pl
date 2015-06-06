factorial(N):- 
	fact(1,N,1).

fact(Y,N,X):-  
	Y>N,
	write(X).

fact(Y,N,X):-
	T is X*Y,
	M is Y+1,
	fact(M,N,T).