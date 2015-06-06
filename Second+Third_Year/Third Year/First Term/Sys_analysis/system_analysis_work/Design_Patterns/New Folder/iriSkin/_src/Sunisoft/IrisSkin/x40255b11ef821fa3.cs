//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin

{
		
		#region Namespace Import Declarations
		
			using System;
			using System.Drawing;
			using System.Runtime.InteropServices;
			
			
		#endregion
		
	internal class x40255b11ef821fa3
	
	{
		
		#region Fields
			public const uint x0007db4e9bc29cf4 = 552;
			public const uint x005306292c45c82b = 1;
			public const uint x00539b2cde5129cd = 2;
			public const uint x006696a86ecb082c = 272;
			public const byte x00713a846d8627ee = 101;
			public const uint x0099d1a3582c25df = 261;
			public const uint x00ae7af37fd7fdc0 = 263;
			public const uint x00b6ff7d4c659513 = 14;
			public const byte x00e14ed236846a89 = 92;
			public const int x00fd6503e20e75d6 = 7;
			public const int x015a4c57e1e8d39b = 32;
			public const uint x01d9ce98fb26683d = 8192;
			public const uint x025a7a48808b9091 = 564;
			public const int x02b19daee7854459 = 3;
			public const uint x02dcedb39ad75c5a = 4111;
			public const uint x02e705c113cfc1e5 = 61792;
			public const uint x02f55a7be88ec15d = 240;
			public const uint x0305e33bdc6f9e79 = 28;
			public const uint x0400e1e53547f97f = 3;
			public const uint x0430f40670f2067e = 74;
			public const uint x043bca94258bbe67 = 3;
			public const uint x0454d6617217f734 = 4106;
			public const uint x04a299551951c283 = 27;
			public const byte x04ba48f5a421349d = 39;
			public const uint x04ee80915aa9872c = 83;
			public const uint x05130cacb5033373 = 523;
			public const int x05252cd3aa1dda30 = 16384;
			public const uint x057f2b286df3eea4 = 61824;
			public const uint x0594e5d17dab53e4 = 6;
			public const uint x059e64ec71afbb71 = 8201;
			public const uint x05a6f0cad94a7a41 = 16384;
			public const short x05ba99717363133e = 1;
			public const uint x05ffc25af122f226 = 8;
			public const uint x06cb9a6f5f367b12 = 279;
			public const uint x07a46841a1dfff3f = 128;
			public const uint x07ac164555740e80 = 164;
			public const uint x080fc67a5cfd27a5 = 2097152;
			public const uint x08aff60a4270def4 = 48;
			public const byte x08b4c0e42b432659 = 103;
			public const uint x09119ac2854877fa = 2;
			public const int x094b68862ed221ca = -16;
			public const uint x09556c5fd594c9e8 = 32;
			public const uint x099475a438c8611d = 247;
			public const int x0a5375e0d0442a10 = 0;
			public const int x0a75d649723d3779 = 9;
			public const uint x0ace38096801619b = 168;
			public const uint x0b0abf7019910365 = 553;
			public const uint x0b2534c32c92b245 = 32512;
			public const uint x0b45dc80d84e5fa0 = 8;
			public const uint x0bac4b10445501bb = 8207;
			public const uint x0bb84864ff1b8bec = 4;
			public const uint x0bbfa72ffff21893 = 16;
			public const uint x0c0ce728cec81edf = 135;
			public const byte x0c3914d51192dc4b = 53;
			public const uint x0caea64735b09bd3 = 134;
			public const uint x0d533bd6791e3ee1 = 82;
			public const int x0d55972abb53b6b3 = 16;
			public const uint x0db588f4003f5ed6 = 5;
			public const byte x0dc4f1c9db23e1be = 89;
			public const uint x0dd7255859b23937 = 233;
			public const uint x0df9d96f490a1619 = 5;
			public const byte x0e421de239ce3d08 = 16;
			public const uint x0e9cfa8f37a701e6 = 3;
			public const uint x0ed43b4a328df774 = 17;
			public const byte x0f279518e73279b1 = 79;
			public const int x0f58462ab57e1bca = 8;
			public const uint x0f5e12a3f39e3a5d = 132;
			public const uint x1014e3f4f6b4ccff = 32514;
			public const int x10200871d1630a92 = 18;
			public const uint x102b7ddad170d2a9 = 16;
			public const uint x1091ca4511a90ba7 = 10;
			public const uint x109b69180cee8fd4 = 2;
			public const uint x11120b7056ea26c1 = 134217728;
			public const uint x1171b1f1f812718e = 100;
			public const uint x11a0985503a2d2df = 4;
			public const byte x11c1afdc16f58560 = 90;
			public const uint x11c51f6983f7537e = 8193;
			public const uint x1220ff5f885bef8d = 273;
			public const uint x123783c4054e2321 = 8192;
			public const int x1259a2227ec4fd76 = 8403;
			public const uint x1300b0517b80ecb0 = 133;
			public const uint x131bf149c6a9959f = 107;
			public const uint x1333f14450f41a16 = 242;
			public const uint x13405a97590b5de2 = 8;
			public const int x1375d89d95905904 = 128;
			public const uint x137dafa913dc73e2 = 529;
			public const uint x13afa8376d6b9c9e = 259;
			public const uint x13b8effdad1debf8 = 67108864;
			public const uint x13c79ed599770bc5 = 1;
			public const uint x14a7264b1a3dd3a8 = 31;
			public const uint x14c937546891f5fb = 61536;
			public const uint x153e76efa8a0b755 = 277;
			public const uint x1582acdeeecafeb4 = uint.MinValue;
			public const uint x159ec68ef8adda78 = 2;
			public const uint x170f55d18b1a9c5b = 6;
			public const uint x171e062db0640ab9 = 131072;
			public const uint x17a554bc7d9645de = 1;
			public const int x17bec02a5b0ae3be = 0;
			public const uint x17d91e6467a1d484 = 7;
			public const int x184d2ab8a4b1dc29 = 8;
			public const int x18507ada08b935bb = 1;
			public const uint x19127004840cf429 = 32;
			public const uint x1938ac7111e2506c = 8;
			public const byte x1964a924bb4d53ea = 70;
			public const int x19748cbe3bd80cce = -20;
			public const uint x19dc70ed25757ede = 4294967294;
			public const uint x19f5b7ffe9eb3a16 = 4159;
			public const uint x1a1aff080c591bff = 22;
			public const int x1a4a0f0a108eecda = -2;
			public const uint x1a9dd746ea76f75e = uint.MinValue;
			public const uint x1b3282b4a1ea5cfc = 2;
			public const uint x1bce19598fd3d508 = 481;
			public const uint x1cab08af5f8f6de5 = 61520;
			public const uint x1ce750ff5ad28825 = 271;
			public const uint x1d9c2dd02bc8675c = 84;
			public const uint x1e9a24819d8351e3 = 517;
			public const uint x1eb04a245493f9b3 = 50;
			public const uint x1ed1fd09381dc095 = 16384;
			public const short x1f0fd5045d7e2d10 = 0;
			public const uint x200df21cb953caa5 = 262144;
			public const uint x20de93c94c9e3b2e = 5;
			public const uint x20e9a6e41ef96a00 = 1;
			public const uint x21061c02bd2dec21 = 16384;
			public const int x21062d710e10a132 = -8;
			public const uint x21919f40dcc29978 = 2;
			public const uint x225d1bf09ff01624 = 51;
			public const byte x22caa889d649848b = 76;
			public const int x22faefb7128e9d04 = 5;
			public const uint x23059b7a1a93ba73 = 275;
			public const uint x2331422d73cc7abc = 256;
			public const uint x233388b5f928233a = 1024;
			public const uint x234494ee3c46e997 = 6;
			public const uint x2346b3c1d9b1dcc9 = 8;
			public const uint x23a04200ca85a7a4 = 101;
			public const uint x23bdd55ef3e480b6 = 68;
			public const uint x244ebbea9f9ab1f1 = 61808;
			public const uint x247d40a3a2f08d46 = 534;
			public const int x24a24846df5ad100 = 64;
			public const uint x253f9d775a52b969 = 113;
			public const byte x25aab8b8398d9767 = 69;
			public const uint x25da92e4935aef55 = 131072;
			public const uint x260b2f31f59ebb36 = 16777216;
			public const uint x26b815d506c8caa1 = 513;
			public const uint x26f484f6df529247 = 32;
			public const uint x2723cd28578e43ba = 87;
			public const uint x2755c42fafcb2a40 = 561;
			public const uint x2766956396b9221c = 32768;
			public const uint x279bd95827a931cf = 4123;
			public const uint x27dcc25debf0ac07 = 256;
			public const uint x27dd06fac5cf8320 = 4110;
			public const uint x281a211ed2ebb998 = 560;
			public const int x28a27fbf4f83e7af = 2;
			public const int x2913c4a85760cfc5 = 2;
			public const uint x294f51702401d47b = 7;
			public const uint x296726b73a9651f2 = 562;
			public const int x296c74cba1425eaa = 0;
			public const int x29984195974d2349 = 8;
			public const byte x2a0cd6abff65e61d = 35;
			public const uint x2a3fe4ac955ec5de = 114;
			public const uint x2a6f62b8980321ad = 6;
			public const int x2b3a2aec098e63ab = 128;
			public const uint x2b7e1c467f38bf4b = 4294967291;
			public const uint x2b7f5d3ca7ec1edf = 2147483648;
			public const uint x2b8fae53e40511c9 = 90;
			public const uint x2c1e2e665d5cfbc8 = 64;
			public const uint x2c44651f5d97dfaa = 160;
			public const uint x2c614abc2f0992c4 = 61728;
			public const uint x2c72428ab00a50dc = 64;
			public const byte x2c97da59f937422f = 162;
			public const uint x2ce5a3a6b0dc70ed = 293;
			public const uint x2d975f89815ed119 = 4294967290;
			public const short x2dab45eb0f3c6fcc = 5;
			public const uint x2df8291dfb1a0d01 = 76;
			public const uint x2e75e013db006dd2 = 531;
			public const uint x2f3244dc34c93f90 = 32643;
			public const byte x2f4f2d35c976d8c8 = 54;
			public const uint x2f78ceb4433b84be = 61456;
			public const uint x2fc7163d3c68f615 = 1024;
			public const int x30301642fcd95fa6 = -10;
			public const uint x303c30370d2f425d = 16;
			public const uint x30a5f17d2a4bac3c = 1;
			public const uint x31d096a3d0b50555 = 128;
			public const int x322bb7712a932850 = 1;
			public const uint x324a5c28d16c39c1 = 8388608;
			public const uint x3272c159adfd1544 = 18;
			public const uint x3358e4000de9a021 = 4098;
			public const uint x339acab5bf3e83ae = 64;
			public const uint x33b6d6d6fc67742a = 2;
			public const uint x33c00bbcdd1a07e2 = 4118;
			public const uint x34506c0e04050cf0 = 307;
			public const uint x34608ae4faf2d468 = 106;
			public const uint x3463638548d827b8 = 294;
			public const uint x3465de9a3630d434 = 3;
			public const int x3485ec91b1bcd5da = 10;
			public const uint x34c1c1d6ae1699dd = 2048;
			public const byte x34cd6b7d75dd356e = 100;
			public const uint x354c82de504d9e8e = uint.MinValue;
			public const uint x3576f0229d2971d7 = 32515;
			public const uint x35e3255797053ba4 = 4;
			public const uint x35f5662311238c75 = 4099;
			public const uint x36326266f9b3e20a = 4294967293;
			public const uint x36e4bf3c3be7c960 = 8210;
			public const uint x36f0874ad534f593 = 6;
			public const uint x373782f78e72c293 = 32;
			public const uint x3773b3a5407e3622 = 2;
			public const uint x37eb6440d9452c9c = 51;
			public const uint x3811215e5d01f164 = 256;
			public const uint x383470bfdd5f33de = 4115;
			public const uint x38e036edf7d38557 = 2;
			public const byte x391f208081ac1f93 = 163;
			public const uint x3922547d9209f159 = 768;
			public const uint x3963774b5e6cb571 = 241;
			public const int x39725d03e9306de4 = 0;
			public const uint x397f4b9ec55e1599 = uint.MinValue;
			public const uint x3983097e70f2140a = 255;
			public const uint x39bc1f595b967b47 = 61584;
			public const uint x3a1e2c56c7117e1f = 4107;
			public const uint x3a23af5e1f690a4d = 234;
			public const uint x3a430e365b0d1167 = 6;
			public const byte x3a867c02d347fe9b = 81;
			public const uint x3aa32f649cf911f0 = 32;
			public const uint x3ab50d2ad9712e32 = 256;
			public const uint x3ae67c1e2c300f57 = 2;
			public const uint x3b6b53845b92fefa = 33554432;
			public const uint x3b6c608012025ae6 = 49;
			public const uint x3baa1a3e4dc71948 = 228;
			public const uint x3be21f04e7ae296d = 246;
			public const uint x3ceadbb2864ed2d8 = 32651;
			public const byte x3ceb98c36a98e468 = 254;
			public const uint x3d6cc65d920c24af = uint.MinValue;
			public const uint x3da23b7853e40581 = 4124;
			public const uint x3dab55fcc1082b3a = 1;
			public const uint x3e0861cdfe5180b9 = 768;
			public const uint x3e66b1230e4356e0 = 34;
			public const uint x3e8b9d6faeff6586 = 32;
			public const uint x3ebf584c85db0e0b = 32649;
			public const uint x3ecff4f9ebcb413a = 29;
			public const uint x3f61b3f62d9c0509 = 227;
			public const uint x3fef1689c0a4f853 = 16;
			public const uint x3ff2d484dbd27a0f = 4294967288;
			public const uint x402fc2b74d843472 = 104;
			public const int x4177a517746987ac = -34;
			public const uint x41b25d649d01f94d = 308;
			public const uint x41dfa22254464ddd = 38;
			public const uint x421067a0297c8a4f = 92;
			public const int x4240fbbb4c651780 = 3;
			public const uint x4283809d4d8a5506 = 4;
			public const uint x4312edc963c22d71 = 61712;
			public const uint x431c98f4133601eb = 27;
			public const uint x438d0d61124171c9 = 21;
			public const byte x438d32ac45cf70fb = 37;
			public const uint x43edce9a61e8724d = 41;
			public const uint x446c1bf74847cdc1 = 42;
			public const uint x44a910a8408cbd15 = 11;
			public const uint x456b09dd2eedf354 = 48;
			public const byte x45b645a141383b7a = 32;
			public const byte x45be08c4b9410087 = 248;
			public const uint x45c8f5ffdb2fee21 = 131072;
			public const uint x4626e751181b29f0 = 2;
			public const byte x4655a170dffd68fd = 161;
			public const uint x466917afea731cd4 = 4;
			public const byte x4669a6d11fc85c47 = 72;
			public const uint x4687c659ad747731 = 46;
			public const uint x4783a0ed7460314a = 32768;
			public const uint x47bd0255f51a9297 = 8211;
			public const byte x480c6d6b352ad669 = 47;
			public const int x48346708676fff18 = -21;
			public const uint x483f26fddc75935e = uint.MinValue;
			public const uint x4881e30b60566ba3 = 512;
			public const uint x4896a14f23431a44 = 64;
			public const uint x48af3a916a6ff4e8 = 8192;
			public const uint x48b983b3d23de59d = 4108;
			public const uint x48ba4268c0326401 = 173;
			public const uint x493c5e5c6260c5df = 4158;
			public const uint x49599aaf0809a329 = 4122;
			public const uint x49b9cc0885c9f3dd = 4133;
			public const uint x4a87bd1a538749d7 = 70;
			public const uint x4a9a1d669c05f614 = 1024;
			public const uint x4ab8cbbd040b4317 = 60;
			public const uint x4ad765a4cc2bbebc = 524288;
			public const uint x4b0f8c0491a74bad = 78;
			public const byte x4b30882cc48a8536 = 34;
			public const uint x4b7cab75a39f3509 = 162;
			public const uint x4b8d5768c76b95b3 = 310;
			public const uint x4c24de5c2db9e720 = 4096;
			public const uint x4c30a3a3ab871e3a = 86;
			public const short x4c4ed64783077b76 = 4;
			public const int x4c60ac0569315376 = 4;
			public const uint x4c63430d9e8ef6a4 = 2097152;
			public const byte x4c7854d9b53d4e94 = 27;
			public const short x4cbeac3a6ec64870 = 11;
			public const uint x4cf22b668e16ca28 = 47;
			public const int x4d3b68bb7d48f369 = 4096;
			public const uint x4d53dd2f5c9046b3 = 4294967280;
			public const int x4df52c30ad496151 = -12;
			public const uint x4e7a04c8de58fa17 = 98;
			public const uint x4ea25acc52b71bba = 97;
			public const byte x4eea7e4d48c37163 = 91;
			public const uint x4f7e9be2fe2b973b = 512;
			public const uint x5101021ee3be4642 = 45;
			public const uint x510aaa9af0268c45 = 533;
			public const uint x5113bc668414e768 = 61440;
			public const uint x51aa82e1f32d91f6 = 512;
			public const uint x51c29577c07ccaea = 296;
			public const uint x5239fd317fe26368 = 59;
			public const byte x52786aaece4f63a9 = 56;
			public const uint x528cd4fe7d397e2d = 4121;
			public const uint x52a3ff3e1c23596a = 225;
			public const uint x52cf71f681015440 = 65536;
			public const uint x52d94b342d53a735 = 4194304;
			public const uint x53116fdac0fedb8d = 16;
			public const byte x531db7a93777c527 = 106;
			public const uint x5369785684a974f4 = 1;
			public const uint x542c7c4ec00011e1 = 67108864;
			public const int x5477469bfc0e4f1e = 2;
			public const uint x54a97421c7348e55 = 30;
			public const byte x54eb418e3a5b3f8e = 108;
			public const byte x54f2d36286b74725 = 40;
			public const uint x569449b69a667ce7 = 12;
			public const uint x56bc112efa724079 = 7;
			public const uint x56de8cfc4545dad3 = 3840;
			public const int x56f1f943fb1153a4 = 5;
			public const uint x5732a82e05540f01 = 14;
			public const uint x573e47af603f9467 = 291;
			public const int x57866789116be4b2 = 7;
			public const uint x578ddffeadbe8f66 = 3072;
			public const byte x57a0544f81ed24d4 = 66;
			public const int x57a058db997bc8b0 = 0;
			public const uint x57d616ecece95fd0 = 4105;
			public const uint x5898cfc7c31e0ba4 = 161;
			public const int x58aa979dc12dfe9a = 17;
			public const uint x58d9b0daa88efdf2 = 4130;
			public const uint x58da8e8ce9edbf01 = 24;
			public const byte x5926aa962f5e36bd = 13;
			public const byte x59de8b4b2cc7aff9 = 84;
			public const uint x59fb0ee4f1e6c31f = 258;
			public const byte x5a8a765112bcddaa = 165;
			public const int x5ad2c2353f4c882b = 19;
			public const uint x5af73999ae018d16 = 8195;
			public const uint x5afa6bef9192b3b3 = 129;
			public const uint x5b0b90a16f187d84 = 65536;
			public const uint x5b2ec36153d60182 = 1;
			public const uint x5b6662d7199de189 = 512;
			public const uint x5bcb1770ba483ad3 = 528;
			public const uint x5c232786b7c28f88 = 93;
			public const uint x5c6ade6b3ec82b5c = uint.MinValue;
			public const uint x5cedce371c2b6eab = 32;
			public const uint x5cfdf038acfa8478 = 520;
			public const uint x5db8f91268d09bb1 = 276;
			public const uint x5e77a0914e0517d2 = 675;
			public const int x5e7af8d0f7c93ee0 = 15;
			public const uint x5e8bfdb547c2a0ea = 65536;
			public const uint x5ea7d4d34b6fa2e1 = 65535;
			public const uint x5ed8176eb46164b3 = 2;
			public const uint x5f1a29f0cf0d33c4 = 515;
			public const uint x604f52b7e371317c = 536870912;
			public const uint x6076ec3085ae9da9 = uint.MinValue;
			public const int x61045fbcf35abab1 = -1;
			public const uint x6123addddbf0de98 = 1;
			public const byte x617081a53f7be049 = 87;
			public const int x61742b8413dda81b = 1;
			public const uint x61814be8439d1ee2 = 8;
			public const uint x61ca10ce87365bff = 4;
			public const uint x6219464a25c631f9 = 8205;
			public const uint x6226b0ef00831da8 = 16777216;
			public const uint x6255a4fa8951c544 = 8192;
			public const uint x62dc83af77560c6f = 91;
			public const uint x6304b97e87b74411 = uint.MinValue;
			public const int x634af14c816901f0 = 4;
			public const uint x63570e92af805629 = 70;
			public const uint x6364bc3b1d5d949a = 4294967284;
			public const uint x63b5386d0936cfee = 89;
			public const short x63bca35693a12e10 = 9;
			public const uint x63cac6accb59aa1d = 8;
			public const int x63d1bdcfa94f1b1d = 16;
			public const uint x640155d148a4fbef = 8200;
			public const uint x64936f43494ca8e7 = 4194304;
			public const uint x64cbf8e7a3e3c5ec = 2;
			public const uint x64d30635abfeaf72 = 4096;
			public const int x653b71dad29cba42 = -32;
			public const uint x6540b143eea5925d = 551;
			public const int x657909aff5ecbca1 = -14;
			public const uint x659d2d0516b1f3aa = 8192;
			public const byte x6605dbfb2b9850fc = 98;
			public const uint x665759714816c0d8 = 8209;
			public const int x667e6545733c00b1 = 8;
			public const uint x66a45d1dd69e248e = 532;
			public const uint x66b87898b9be457b = 20;
			public const uint x66c4802afcc0e41d = 36;
			public const uint x679c20626d796127 = 61472;
			public const uint x67cafc49fb9992aa = 26;
			public const uint x68a35c7fc1b235ac = 30;
			public const uint x68c74e9c884ec08e = 1;
			public const uint x697ec4492146b403 = 1073741824;
			public const int x69bd1dabc920b165 = 6;
			public const byte x69e492671de4e025 = 107;
			public const uint x69ed84f24c496ae4 = 45;
			public const uint x69f81ff6c2e1fec0 = 32645;
			public const int x6a2004b6ad6c17a0 = 5;
			public const uint x6abb0c3dfa26da7b = 269;
			public const uint x6b16c995aed4c019 = 2048;
			public const uint x6b4a283c1aa5fc2e = 311;
			public const int x6b6981f51c2f10ad = 10;
			public const uint x6b8a197eda72bb0f = 230;
			public const uint x6c042714b95b1434 = 5;
			public const uint x6c0b8b37c6254848 = 61488;
			public const uint x6c9936ed82085c73 = 32516;
			public const uint x6d1ada3bef56800a = 4116;
			public const uint x6d470be2fd676c04 = 268435456;
			public const uint x6d6c1fcfe360b7af = 536870912;
			public const byte x6d98062bc2fd99a8 = 86;
			public const uint x6dde1b00cb6c78df = 1;
			public const uint x6dde47029dbc3218 = 1024;
			public const byte x6e1b0f1cf44da43e = 80;
			public const uint x6e82921bea1de07d = 768;
			public const int x6e8d259e3d88f80d = -1;
			public const uint x6ea2da857a1275c7 = 19;
			public const uint x6ea3cb70718497ae = 268435456;
			public const int x6eb0c360baa7a996 = -18;
			public const byte x6f5a3c1ed62642ef = 75;
			public const uint x6f764e471c25d5be = 524288;
			public const byte x6fa57e2ca0d9d6a5 = 97;
			public const uint x6ff6a339d7a89e80 = 4100;
			public const int x70905dd0c33588f1 = 14;
			public const uint x70c94cefe4a640bc = 8198;
			public const uint x71465a7bfa138ae8 = 524288;
			public const uint x71697616569d8e5c = uint.MinValue;
			public const uint x71b4fc377086bb0b = 64;
			public const byte x71e09360d9694ebf = 8;
			public const uint x71e360a3036a9ec0 = 514;
			public const uint x72323cce87c5ec43 = 32641;
			public const uint x723f743f8f250ba8 = 43;
			public const uint x724831f16f0b1d1e = 50;
			public const int x7260e2e8b818e128 = 2;
			public const byte x72ac364e79a2ec23 = 111;
			public const uint x72b6b1fc2d8fc5ed = 256;
			public const byte x72d7fed22858db20 = 71;
			public const uint x7346b25c7a8b226e = uint.MinValue;
			public const uint x7358895d8e0475cf = 1;
			public const byte x73905c432ba461d6 = 253;
			public const uint x73fa3389694ad7cb = 40;
			public const uint x73fdd1f125894ead = 4135;
			public const uint x740c8d6bf960bb9f = 4126;
			public const int x747bbbf9cdd2d1d6 = 256;
			public const uint x748e877ad3b8a1c7 = 521;
			public const int x74cf6037170cbd28 = 0;
			public const uint x74e468c028bd2781 = 166;
			public const uint x74ed3993793c74b1 = 312;
			public const uint x750be83cc0513c31 = 61;
			public const uint x759773a65c86bb84 = 512;
			public const uint x760a1e4ab345de08 = 15;
			public const uint x76322a7696ecd0f6 = 65536;
			public const uint x7632d73ff257d6ce = 512;
			public const uint x766aa938adb0f367 = 128;
			public const uint x76c25d95a5fe6bc2 = 32;
			public const uint x773e7f69a1334e39 = 56;
			public const uint x778b93109439bf10 = 28;
			public const uint x77bf04ec211c4a37 = 16;
			public const uint x789f45f29977cb3b = 544;
			public const uint x78a4bb3d55c147d1 = 25;
			public const int x78cb76eae4f0d827 = 8402;
			public const uint x78e70211e1931efa = 34;
			public const int x799d470ca34314da = -8;
			public const uint x79f232b060bef0c1 = 2;
			public const uint x7a2cc8eaa2a5c502 = 8203;
			public const uint x7a452af3f8815b0f = 1;
			public const int x7a5a2fe987522c37 = 4;
			public const uint x7c0a61d84722b507 = 4194304;
			public const int x7c10fbffcf0b29db = 2;
			public const uint x7cb34a54450ee805 = 128;
			public const uint x7d380b8e4fcc6153 = 674;
			public const uint x7d407e9ec146fdf0 = 262144;
			public const uint x7dd86c0b0d317ffa = 2;
			public const uint x7f1d07ef65550836 = 16384;
			public const uint x7f3c1f8dd02a51f4 = 5;
			public const int x801b6cb281f3775d = 0;
			public const uint x80ce72f3ac4efcf9 = 47;
			public const uint x816dfdf52ce705ba = 64;
			public const int x81a880c834156129 = 0;
			public const byte x81f7b39510cb13e8 = 49;
			public const uint x8208ca6b17e432e9 = 4;
			public const int x821f9d59dbc5e141 = 4;
			public const int x82457a68f3be01a2 = 12;
			public const uint x826beb9e78c89e3d = 69;
			public const uint x82e5495c24d38ed6 = 1;
			public const uint x82fbfdbd525ca6b3 = 4294967287;
			public const byte x832e34128235d61b = 20;
			public const uint x83453180f691eabf = 32;
			public const uint x836e53e090609b16 = 4132;
			public const uint x838016b427dbe410 = 1048576;
			public const uint x83e11e1984608548 = uint.MinValue;
			public const uint x83e26ee62a1d9577 = 8192;
			public const uint x840b2196507a649d = 245;
			public const uint x8419f1cdd9b8ed8b = 4102;
			public const short x8456c03da62335d0 = 3;
			public const uint x84bd9fa86ba1ece5 = 3;
			public const int x84c0e2904139734f = 12;
			public const uint x84c86f9ae2759522 = 392;
			public const int x84fcaaf7efecfd3f = -12;
			public const int x853cdeb4f5626860 = 0;
			public const uint x85ad80e34133c292 = 3;
			public const uint x85eef95e927a6fb6 = 61568;
			public const uint x85faec6d9e71460c = 11;
			public const uint x860f7a917546f6a2 = 66;
			public const byte x862ff9800de080c9 = 50;
			public const byte x8649eaad3a0eb533 = 48;
			public const uint x86717c0ac14aa845 = 136;
			public const uint x86854994e8aabee7 = 39;
			public const uint x8693a3fd66195d83 = 36;
			public const uint x86d7424e519fa843 = 73;
			public const uint x876b5677fdbd13ab = 289;
			public const uint x87fed0b8262b2701 = 256;
			public const uint x8855556f0217fa0b = 64;
			public const uint x894a0c6f73f5124f = 23;
			public const uint x89eb8713c4c43eaa = 16;
			public const int x8a088cc0adc307e6 = 1024;
			public const int x8a177838fa8a5581 = -1;
			public const uint x8a2b21366e4510e5 = 548;
			public const int x8a600961a2a73d2e = 7;
			public const uint x8ada1d170f4d67ae = 131;
			public const uint x8b7b8662dfe07182 = 65536;
			public const uint x8b950f33b878e25f = 4;
			public const uint x8ba81c0d3401280f = 265;
			public const uint x8baed6bb44a0f24e = 52;
			public const uint x8bb5d36e77aa3f7e = 55;
			public const uint x8bfb90ddb179d484 = uint.MinValue;
			public const int x8c65df2dcef30621 = 14;
			public const uint x8c81a205a938be50 = 8196;
			public const byte x8ceca687448009a1 = 1;
			public const uint x8d1c1acfa9e97cb1 = 65536;
			public const uint x8d22b0905f68e0ef = 8206;
			public const uint x8dcf40f9c4b56143 = 8;
			public const uint x8def1e3a6d5d9e1d = 4096;
			public const uint x8e3d17a0b8380e7e = 243;
			public const uint x8e3f53e2ec20c554 = 65;
			public const uint x8e7f4c8a371be9bc = 112;
			public const uint x8eadc5fc1d3d9e55 = 8192;
			public const int x8f26605f5345eaa3 = 512;
			public const uint x8f53bcf3f494a83b = 5;
			public const uint x8f650780f638436c = 4;
			public const int x8f7b381071e69b8e = 2;
			public const uint x9075558fd294e331 = 1;
			public const uint x90846aa16cb2e820 = 2;
			public const uint x908e50607ddc94f5 = 80;
			public const uint x909f72538f52db3e = 2;
			public const short x9164278ad0ab167b = 8;
			public const uint x92803739688048a1 = 8;
			public const short x92abbd28131fce0d = 7;
			public const uint x930a2570eb82396f = 75;
			public const uint x93aa4d1393ee549c = 4128;
			public const uint x93b283a033d1b54a = 2;
			public const uint x9404df0a9b400875 = 7;
			public const uint x943968cbf6591648 = uint.MinValue;
			public const uint x9477e69d2aede431 = 81;
			public const byte x94f3e1f6055486d7 = 17;
			public const byte x9539155b20efeb2a = 104;
			public const uint x95432e192aa59198 = 256;
			public const uint x954951a7b1eb756c = 8204;
			public const uint x9576b3f0ea4a5537 = 54;
			public const int x9592f28dbffa311e = -16;
			public const uint x95b47b96b1408e86 = 4;
			public const int x95bb1aec6e0fba71 = 0;
			public const uint x96ade6f67616c32a = 61760;
			public const int x973b973db1bba048 = -4;
			public const uint x97810ed8402ea8f3 = 518;
			public const uint x97da79fdb2be46ef = 1;
			public const uint x983c451d3c46e708 = 7;
			public const uint x987551c2d1c23550 = 103;
			public const uint x98a2ab671e31516d = 309;
			public const int x98caf956cd780993 = 4;
			public const uint x9a60edef81399466 = 33;
			public const int x9a7472f27d33b1d3 = 1;
			public const uint x9a9f92cafa28f919 = 306;
			public const int x9b0d022ddeb262f1 = 256;
			public const uint x9b4bcbe396f53023 = 97;
			public const uint x9b9a887d0b9cd4aa = 102;
			public const uint x9bbed5964222e1b1 = 4;
			public const uint x9bd43ced7ab10251 = 65536;
			public const int x9bf8cbe39b2dd8f0 = 1;
			public const uint x9c673b0bf1265ea9 = 224;
			public const uint x9c8a0456810e683a = 522;
			public const int x9c9c12a12b0661fe = 14;
			public const uint x9d5366886d829b54 = 262144;
			public const uint x9e72e1fc89a4d09f = 260;
			public const uint x9e77ed8dc48b3f36 = 4117;
			public const int x9ed35e6e8b872d5e = -1;
			public const uint x9f6c73fff0f12ffc = 32;
			public const byte x9f8bfa28fd978048 = 33;
			public const uint x9ffe5d3651ade72b = 1048576;
			public const uint xa0302372950d135a = 131072;
			public const uint xa10370414e9cb1c7 = 72;
			public const int xa12bdc734dcef373 = 14;
			public const uint xa13bd9294960d2ec = 16;
			public const int xa19a5e7e65d67a02 = -2;
			public const byte xa1cfcecc2bbf1b88 = 9;
			public const uint xa1fa08aba27b7a77 = 10;
			public const int xa28f4983b2780308 = 0;
			public const uint xa2d068383735e30f = 61552;
			public const uint xa2f9edb3d8404cb7 = 37;
			public const byte xa34cc3e091661d7f = 1;
			public const uint xa3d725a435bc9f12 = 512;
			public const byte xa40dffb140dfceec = 93;
			public const uint xa4618c043175a071 = 19;
			public const int xa482a83c160d1d75 = 13;
			public const uint xa4941f0e6d50729c = 58;
			public const uint xa53e2fbf04b4c5eb = 15;
			public const uint xa55387511761cedb = 6;
			public const uint xa5b46091992e5ddc = 32644;
			public const uint xa60f268067e38e46 = 12;
			public const uint xa66659e2001edfe0 = uint.MinValue;
			public const int xa6b34d706cb2724a = -6;
			public const uint xa740800cf69e5078 = 8208;
			public const uint xa77137d31a170367 = 4;
			public const uint xa78f6eaeea024f7a = 545;
			public const uint xa7b69bc50e8a0f9a = 38;
			public const uint xa832a50c4427a864 = 524;
			public const byte xa8c9b6f56e5eea9b = 85;
			public const uint xa8cc7ffe6f7ea07d = 4096;
			public const byte xa943e0844f677004 = 74;
			public const uint xa94a2b340d7cb97e = 549;
			public const uint xa98f8e479b641593 = 4;
			public const uint xaa1e44ca59117f0b = 57;
			public const uint xaa2eaaab1e016228 = 42;
			public const uint xaa4b1657208ad499 = 134217728;
			public const int xab4c528250c99d5b = 2048;
			public const uint xab5048bdc7317373 = 4;
			public const uint xab6ba3a74cfda5af = 21;
			public const uint xac5f9b40255c0e13 = 8;
			public const uint xac6f737df17031c5 = 297;
			public const uint xac9de6490629690d = 4119;
			public const uint xacaf912f8e96627a = 257;
			public const uint xacdc852c2212287c = 105;
			public const uint xad2c4838c7f4b06e = 163;
			public const uint xad4cdcd8d0e20335 = 88;
			public const uint xad8d4aa157659af8 = 20;
			public const byte xadefa335d9a11adf = 18;
			public const int xae1aa6ecfee76f8a = 8401;
			public const uint xae233973998c4218 = 1;
			public const uint xae9dc1e92d6cd5a6 = 2;
			public const uint xaf51e5be7629d138 = 547;
			public const uint xb0452d49e13ad2e6 = 77;
			public const uint xb074ad72426e1dcc = uint.MinValue;
			public const uint xb077a7d71860add3 = 2;
			public const uint xb081910ac2973d37 = 10;
			public const uint xb0e5cdfb2cbe2183 = uint.MinValue;
			public const uint xb0ea72a57d64450d = 8;
			public const int xb0ef242ee2f7843b = 21;
			public const uint xb1042a18187fb42c = 16;
			public const uint xb112e63aff62927b = 65;
			public const uint xb18a64056e74ece9 = 516;
			public const uint xb18fa2e26fc623df = 16;
			public const uint xb1cfd9cd0c5b6b07 = 550;
			public const int xb20c8d8cc3050d4b = -20;
			public const uint xb25e206e5e211fc6 = 4125;
			public const uint xb2a1ddb7666577d3 = 525;
			public const uint xb342911ee4ecb216 = 169;
			public const int xb3566b1844117d26 = 6;
			public const uint xb363b929d766ea86 = 32768;
			public const int xb396ff63032c8e12 = 9;
			public const int xb39e25e70f9c50b7 = 9;
			public const uint xb44f3bfbcc66ab2e = 3;
			public const uint xb450a4d7347f3a17 = 72;
			public const uint xb498cf3889f795e3 = 262;
			public const int xb5478fefbcf78dda = 17;
			public const uint xb615ddf284afbdf6 = 524288;
			public const uint xb638d4ff2e7b1071 = 110;
			public const uint xb644deafcaa222c4 = 2;
			public const uint xb6a0c37dab7f7739 = 530;
			public const uint xb6b40fc72abcbf59 = 262144;
			public const uint xb6e40becd815c95b = 31;
			public const uint xb7a8171a6a88db61 = 4127;
			public const uint xb80ff1a5273e22fc = 95;
			public const uint xb85bfe89f622f188 = 4;
			public const uint xb87c06a18c2010a7 = 61776;
			public const uint xb8a822e576f3bf60 = 1;
			public const uint xb8b3528a7257727e = 5;
			public const uint xb8c4cf235c40c065 = 4097;
			public const uint xb8c73219f3f57d82 = 4;
			public const uint xb8cb7c1b5de8c712 = 167;
			public const byte xb8f5ee2a7c59c10e = 73;
			public const uint xb8f652a8b970e2b9 = 46;
			public const uint xb913f34816812fce = 3;
			public const uint xb91892fcecbcf802 = 295;
			public const uint xb92fdbe092b7fb22 = uint.MinValue;
			public const uint xb9e32e9780b7e8df = 256;
			public const byte xba1b83ed63dc415f = 82;
			public const uint xba269b7f1c7361ac = 4109;
			public const uint xba4af6b0981d62f1 = 11;
			public const uint xba7797a2c28bce5b = 61504;
			public const byte xbaed8a7288356285 = 65;
			public const byte xbb29ad11ce20034c = 102;
			public const short xbb71b62df882b973 = 2;
			public const byte xbb8447638786d84b = 250;
			public const int xbb8fe7816eba2a16 = 512;
			public const uint xbb95e21975148569 = 63;
			public const uint xbba2e3322304014b = 75;
			public const uint xbbb8ca0e2f600ece = 4294967285;
			public const uint xbbc5f917302ab7c3 = 271;
			public const uint xbbe79e535b6841ac = 4104;
			public const byte xbc635c0c490c55fc = 36;
			public const uint xbc6ad979d688348e = 24;
			public const int xbc8642b662b734a2 = 9;
			public const uint xbc89da9d33955b47 = 13;
			public const uint xbcfac9f25650a44f = 2;
			public const byte xbd61b67cc6848385 = 78;
			public const uint xbd823649fd43c453 = 94;
			public const uint xbd846108ad20acaa = 4131;
			public const uint xbdaf3cc1e7827125 = 44;
			public const uint xbdedc75c4dae6803 = 85;
			public const uint xbe0bbb4e69f130dd = 2;
			public const uint xbedc7aebf6eecbfd = uint.MaxValue;
			public const short xbf220f39ab187c94 = 1;
			public const uint xbf4c7875b0d88244 = 1024;
			public const uint xc075432fea956c33 = 8;
			public const uint xc0f5ff203f460264 = 130;
			public const uint xc202c078f9d61f43 = 8202;
			public const uint xc24777e84425a6d1 = 131072;
			public const uint xc24d3505fd35a942 = 1048576;
			public const uint xc2c10bb12575fdc0 = 16;
			public const int xc3a301c22fbda290 = 13;
			public const uint xc439507d4c3e3e67 = 8199;
			public const uint xc4609cc7096d8d85 = 4096;
			public const byte xc4984f602d4ceeb7 = 160;
			public const uint xc4d72d8fc359257f = 8192;
			public const uint xc58cbf179cc409a6 = 48;
			public const byte xc598e9abfb528d5f = 164;
			public const uint xc5b947adbc3a81cd = uint.MinValue;
			public const uint xc5eec284e0471e93 = 171;
			public const uint xc664eb39a2f4f668 = 4;
			public const uint xc6b268692981367b = 256;
			public const byte xc6d2f03296631538 = 109;
			public const uint xc6dbe9c449dff90e = 64;
			public const int xc8abef4e65a69a2b = 128;
			public const int xc8b80568cb6e0986 = 20;
			public const uint xc93403e113a26f94 = 8194;
			public const uint xc94bd615d7a6acc5 = uint.MinValue;
			public const uint xc97638cda7666d1e = 270;
			public const byte xc995d496da2e32a1 = 68;
			public const byte xc9d35603dd20e39f = 99;
			public const uint xcae2095a62cf0488 = 563;
			public const byte xcb2f4e8a88b181d5 = 247;
			public const short xcb40a7dbd8dbfb40 = 10;
			public const int xcb6932c7a1d6f3ec = -24;
			public const uint xcb851d77f761ad86 = 12582912;
			public const uint xcb9a6af1051f41d2 = 4134;
			public const uint xcbb6a4b72338c6cd = 96;
			public const byte xcc0151241e0a0d84 = 41;
			public const uint xcc06abe9ea580b1d = 4107;
			public const uint xcc511a20994ca7fd = 53;
			public const uint xcc781840d1708149 = 165;
			public const int xccff8f4204934408 = 4096;
			public const uint xcd1a54219f170e30 = 262144;
			public const uint xcd390c5181df4669 = 15;
			public const uint xcd5063d7edfe64f1 = 240;
			public const int xcd6f3cae1f4d0618 = 5;
			public const uint xce600006eee70ddf = 2;
			public const uint xce8828cd9b8d47fd = 1;
			public const uint xcecce5107afc6470 = uint.MinValue;
			public const uint xcf41656e5de3c24a = 1;
			public const uint xcf579a708f9627b2 = 4129;
			public const uint xcf964c64f7a5233f = 5;
			public const uint xd0a3bddd22f5a327 = 244;
			public const int xd175f46fd299041f = 8192;
			public const uint xd1ae0cadc43e7fde = 4;
			public const uint xd1ba951785fa5a83 = 4096;
			public const uint xd2f90fe20994ec33 = 6;
			public const uint xd34aefa7433ebae2 = 32768;
			public const uint xd3529724756cd58d = 26;
			public const uint xd3b28a0cc233143f = 292;
			public const uint xd42d253d98b1ffec = 32650;
			public const uint xd456a7d38ca71c79 = 3;
			public const uint xd50598fe140dcb07 = 512;
			public const uint xd5488f8014b3a75c = 12288;
			public const uint xd55145832cc145dd = 71;
			public const uint xd5b8fa4baa7d25e6 = 4106;
			public const uint xd5fae91bfbb9bd21 = 64;
			public const uint xd60d10229211cc08 = 128;
			public const byte xd6202431e406dddb = 88;
			public const byte xd6e99cb3d4f7a3a1 = 52;
			public const uint xd6efdc065e64f177 = 26;
			public const uint xd6f5e2bbd424107c = 44;
			public const uint xd708511d2241a4fb = 131072;
			public const uint xd76b4083404e6a5b = 67;
			public const int xd79e1ddae88fa7c3 = -26;
			public const byte xd7f37ec187278d53 = 252;
			public const uint xd803c76f54f8bcbc = 2147483648;
			public const uint xd89226aa56afd13c = 61455;
			public const uint xd8fe215e99f5d936 = 519;
			public const int xd9240a9422ef5cef = 256;
			public const uint xd98fd3801a94103d = 1;
			public const uint xda033fd75c409322 = 1024;
			public const uint xda3dc7745b45271c = 1;
			public const uint xdab9407383a12ce8 = 290;
			public const uint xdaeb0288da6ca815 = 546;
			public const byte xdaf5ecad9bdedfe2 = 83;
			public const uint xdb1f8cb996aac237 = 111;
			public const uint xdb370011d19b7529 = 287;
			public const uint xdb37118a0c2118b6 = 274;
			public const uint xdb9e3bb1d4b6a7b5 = 288;
			public const uint xdbadeaa89fa87004 = 16;
			public const uint xdbb7427772b219d6 = 128;
			public const int xdbc5fb46f279c4c7 = 1;
			public const uint xdbf3dacb63e7a493 = 33554432;
			public const int xdc2e4530f6aca604 = 6;
			public const uint xdc88b50ed9fedf8c = 61;
			public const uint xdcb34bb1190e972e = 8197;
			public const uint xdd079ada4cda11ef = 32642;
			public const byte xdd0a71f0db534890 = 251;
			public const uint xdd587b552422d59c = 49152;
			public const byte xdd6043f42253ee15 = byte.MinValue;
			public const uint xddf2ae12c3baaf0b = 68;
			public const uint xde195ac37cf6f5bd = 49;
			public const uint xde2bf48bdf1fa2a6 = 16;
			public const byte xde5ac90a74a60e30 = 96;
			public const uint xde8c48beb2ff03d6 = 16;
			public const uint xdf5a82708581a10d = 768;
			public const int xdf87e8ef5eb781bb = 11;
			public const uint xdfe94fe453101a8e = 35;
			public const uint xe004119ec365f03a = 4;
			public const uint xe0714e53b15b24d2 = 2;
			public const uint xe0956b950b7cf92e = 43;
			public const uint xe09b5dfd3152803c = 16384;
			public const byte xe101980198542976 = 105;
			public const uint xe1db6ccdf0c48661 = 2048;
			public const uint xe28f9ceebee2f6d9 = 2097152;
			public const uint xe30b4278f977aca4 = 61744;
			public const uint xe3489c4befae416c = 4294967292;
			public const uint xe351685bc1013926 = 3;
			public const uint xe39e6e43cda4a0e3 = 22;
			public const byte xe415d947511ad46e = 51;
			public const int xe50990f0188adf4d = 16384;
			public const int xe51f0976a1c27f30 = 22;
			public const uint xe5355863198053b5 = 115;
			public const uint xe5537e3fdccd98e1 = 1;
			public const int xe56cda6d9da2b8e1 = 3;
			public const int xe57a2487098edad5 = 11;
			public const uint xe58ac556cc22a8ef = 61696;
			public const uint xe60f5e2debede6ec = 71;
			public const uint xe64e33269cf51260 = 16384;
			public const uint xe6cdb43fe0ec5ccc = 4;
			public const int xe6d9d0a81d734323 = 3;
			public const int xe70b8e2b66f3c980 = 3;
			public const byte xe78161aace69ad71 = 12;
			public const uint xe7a8078ad50bd781 = 4114;
			public const uint xe8407fe39c92388b = 3;
			public const uint xe843427058fef0f4 = 128;
			public const uint xe85e09c375113dd0 = 74;
			public const uint xe864073ec97bd5d0 = 17;
			public const int xe8adba66ee59f491 = -1;
			public const uint xe8c7f4c9fc51338e = 9;
			public const uint xe8fbefc8597da88a = 64;
			public const uint xe92f1f7c913d535c = 29;
			public const int xe95e0927fd3bc7dd = 32768;
			public const byte xe994fac6ade8de8b = 249;
			public const uint xea1fd4b6a9a9d164 = 62;
			public const uint xea45843083ba11c3 = 131072;
			public const uint xea6f3921387d06c6 = 265;
			public const uint xeaa67d27b4965bbd = 33;
			public const uint xeaf45a25f7bd026f = 1;
			public const uint xec00eaee1f8cd178 = 2;
			public const short xeda48ea6bea5e0b3 = 3;
			public const uint xedbbfda9fc91c36d = 32;
			public const uint xedd102ef6295a142 = 57;
			public const uint xede827bccd6c7d27 = 1073741823;
			public const uint xee446676c0cb2553 = 172;
			public const uint xee5a457663a6b229 = 128;
			public const uint xee7a13083e4f6fb5 = 8;
			public const int xef09000ba00ddcbe = 4;
			public const uint xef5dfd67de8c4dd1 = 2;
			public const int xef6f2af1639b6858 = 10;
			public const int xefb603eac5e58721 = 3;
			public const int xefb6d00864628b14 = 8;
			public const uint xefc92ca4c57f7d9b = 6;
			public const byte xefe79498fcbd4cf5 = 3;
			public const uint xf04f3e12826f6236 = 226;
			public const uint xf05bb23303debfce = 1048576;
			public const uint xf0b770e7e77f6858 = 99;
			public const uint xf0ee657992726e07 = 1073741824;
			public const short xf11437e4dd1df523 = 6;
			public const uint xf1867eb68ccbcdd5 = 55;
			public const uint xf201f2dc10b14b6d = 1;
			public const byte xf2427f213046da38 = 67;
			public const uint xf257320505f92a88 = 18;
			public const uint xf26db2b865e10b83 = 32646;
			public const byte xf2fb8caa1967bf5e = 110;
			public const uint xf33cb363d5449d35 = 16;
			public const int xf34177ba6c778d56 = 4;
			public const uint xf354b08ec5356e35 = 15;
			public const uint xf3ff80b750b3837c = 1;
			public const uint xf40571c086fcabbe = 8388608;
			public const uint xf58f5e712cc43414 = 32513;
			public const int xf5afca3ce3291e58 = 5;
			public const byte xf5ee4609a7a1f302 = 38;
			public const short xf68f46897181736b = 11;
			public const uint xf6fa315d08e9d9aa = 262144;
			public const byte xf6fd8cb37ad1be0b = 246;
			public const uint xf816e708aa166d8f = 13;
			public const uint xf8aa33226e8519ef = 79;
			public const uint xf8e51ad039ee4e1f = 32;
			public const uint xf9440d839b8d0898 = 4120;
			public const uint xf97f830a3a8d78af = 278;
			public const byte xf9a6d3173e5bb3f4 = 44;
			public const uint xf9bb3ec757d1f392 = 2;
			public const byte xfa64228095123811 = 43;
			public const uint xfb40744390d5a75f = 32648;
			public const uint xfbdae70f07a583ec = 4294967286;
			public const uint xfbe8d59bbda24e93 = 4103;
			public const uint xfbecf9372e151435 = 32640;
			public const uint xfc6105f4d63016a5 = 4101;
			public const byte xfca4f13509cf5244 = 77;
			public const uint xfcc560da0fa0a928 = uint.MinValue;
			public const uint xfccdf1179336167d = 4294967289;
			public const int xfcde88cc2cb64c0c = 1;
			public const uint xfd2e4ee0fa0a32f0 = 524288;
			public const uint xfdbf27838e5e3e7d = 48;
			public const uint xfe06a623c25f2e64 = 525;
			public const uint xfe29f12fb7852950 = 512;
			public const uint xfe2b3da279f60585 = 2;
			public const uint xfe3dd2ebb91c29b3 = 31;
			public const byte xfe70672057380e14 = 55;
			public const uint xfee9d21e3067f4e5 = 1;
			public const byte xff241c9d5a88c89e = 57;
			public const uint xff9a50fe1729f560 = 3;
			public const uint xff9b25ea232096b2 = 35;
			public const uint xffacb6e34fa30aa0 = 32;
			public const uint xffd27331c135ee6c = 512;
		#endregion
		
		#region Nested Types
		
			[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
			public struct CBT_CREATEWND
			
			{
				public IntPtr lpcs;
				public IntPtr hwndInsertAfter;
			}
			
			
			[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
			public struct COMBOBOXINFO
			
			{
				public uint cbSize;
				public xae4dd1cafd2eb77c.RECT rcItem;
				public xae4dd1cafd2eb77c.RECT rcButton;
				public uint stateButton;
				public IntPtr hwndCombo;
				public IntPtr hwndItem;
				public IntPtr hwndList;
			}
			
			
			[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
			public struct CREATESTRUCT
			
			{
				public IntPtr lpCreateParams;
				public IntPtr hInstance;
				public IntPtr hMenu;
				public IntPtr hwndParent;
				public int cy;
				public int cx;
				public int y;
				public int x;
				public long style;
				public IntPtr lpszName;
				public IntPtr lpszClass;
				public uint dwExStyle;
			}
			
			
			[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
			public struct LOGFONT
			
			{
				public int lfHeight;
				public int lfWidth;
				public int lfEscapement;
				public int lfOrientation;
				public int lfWeight;
				public byte lfItalic;
				public byte lfUnderline;
				public byte lfStrikeOut;
				public byte lfCharSet;
				public byte lfOutPrecision;
				public byte lfClipPrecision;
				public byte lfQuality;
				public byte lfPitchAndFamily;
				[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 0020)]
				public byte[] lfFaceName;
			}
			
			
			[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
			public struct MSG
			
			{
				public IntPtr hwnd;
				public uint message;
				public IntPtr wParam;
				public IntPtr lParam;
				public int time;
				public int pt_x;
				public int pt_y;
			}
			
			
			[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
			public struct NCCALCSIZE_PARAMS
			
			{
				public Rectangle rgrc0;
				public Rectangle rgrc1;
				public Rectangle rgrc2;
				public IntPtr lppos;
			}
			
			
			[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
			public struct NONCLIENTMETRICS
			
			{
				public uint cbSize;
				public int iBorderWidth;
				public int iScrollWidth;
				public int iScrollHeight;
				public int iCaptionWidth;
				public int iCaptionHeight;
				public int iSmCaptionWidth;
				public int iSmCaptionHeight;
				[MarshalAsAttribute(UnmanagedType.Struct)]
				public x40255b11ef821fa3.LOGFONT lfCaptionFont;
				public int iMenuWidth;
				public int iMenuHeight;
				[MarshalAsAttribute(UnmanagedType.Struct)]
				public x40255b11ef821fa3.LOGFONT lfSmCaptionFont;
				[MarshalAsAttribute(UnmanagedType.Struct)]
				public x40255b11ef821fa3.LOGFONT lfMenuFont;
				[MarshalAsAttribute(UnmanagedType.Struct)]
				public x40255b11ef821fa3.LOGFONT lfStatusFont;
				[MarshalAsAttribute(UnmanagedType.Struct)]
				public x40255b11ef821fa3.LOGFONT lfMessageFont;
			}
			
			
			[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
			public struct PAINTSTRUCT
			
			{
				public IntPtr hdc;
				public int fErase;
				public Rectangle rcPaint;
				public int fRestore;
				public int fIncUpdate;
				[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 0020)]
				public byte[] rgbReserved;
			}
			
			
			[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
			public struct SCROLLBARINFO
			
			{
				public uint cbSize;
				public xae4dd1cafd2eb77c.RECT rcScrollBar;
				public int dxyLineButton;
				public int xyThumbTop;
				public int xyThumbBottom;
				public int reserved;
				[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 0018)]
				public uint[] rgstate;
			}
			
			
			[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
			public struct SCROLLINFO
			
			{
				public uint cbSize;
				public uint fMask;
				public int nMin;
				public int nMax;
				public uint nPage;
				public int nPos;
				public int nTrackPos;
			}
			
			
			[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
			public struct STYLESTRUCT
			
			{
				public uint styleOld;
				public uint styleNew;
			}
			
			
			[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
			public struct TITLEBARINFO
			
			{
				public uint cbSize;
				public xae4dd1cafd2eb77c.RECT rcTitleBar;
				[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 0006)]
				public uint[] rgstate;
			}
			
			
			[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
			public struct TRACKMOUSEEVENTS
			
			{
				public uint cbSize;
				public uint dwFlags;
				public IntPtr hWnd;
				public uint dwHoverTime;
			}
			
			
			[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
			public struct WINDOWINFO
			
			{
				public uint cbSize;
				public Rectangle rcWindow;
				public Rectangle rcClient;
				public uint dwStyle;
				public uint dwExStyle;
				public uint dwWindowStatus;
				public uint cxWindowBorders;
				public uint cyWindowBorders;
				private short xd5bc19ea3b69957a;
				private short x4fef15cc26e7f565;
			}
			
			
			[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
			public struct WINDOWPLACEMENT
			
			{
				public uint length;
				public uint flags;
				public uint showCmd;
				public Point ptMinPosition;
				public Point ptMaxPosition;
				public Rectangle rcNormalPosition;
			}
			
			
			[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
			public struct WINDOWPOS
			
			{
				public IntPtr hwnd;
				public IntPtr hwndInsertAfter;
				public int x;
				public int y;
				public int cx;
				public int cy;
				public uint flags;
			}
			
		#endregion
		
		#region Constructors
		
			public x40255b11ef821fa3 ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ret 
			*/
		#endregion
	}
	
}

