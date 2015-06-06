inserta([H|T],E,[E,H|T]):-
	E<H.
inserta([H|T],E,[H|Nl]):-
	inserta(T,E,Nl).

