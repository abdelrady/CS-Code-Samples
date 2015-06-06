sum(void,0).
sum(btree(R,LT,RT),S):-
	sum(LT,NS),
	sum(RT,MS),
	S is NS+MS.