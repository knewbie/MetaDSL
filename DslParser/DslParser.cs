// DslParser.cs - generated by the SLK parser generator
using Dsl.Common;

namespace Dsl.Parser
{

    static class DslParser
    {

private static short[] Production = {0

,2,56,57 ,3,57,58,109 ,3,58,76,152 ,3,59,77,152 ,3,60,78,152 
,3,61,79,152 ,3,62,80,152 ,3,63,81,152 ,3,64,82,152 
,3,65,83,152 ,3,66,84,152 ,3,67,85,152 ,3,68,86,152 
,3,69,87,152 ,3,70,88,152 ,3,71,89,152 ,3,72,90,152 
,3,73,91,152 ,3,74,92,152 ,3,75,93,152 ,3,76,77,110 
,3,77,78,111 ,3,78,79,112 ,3,79,80,113 ,3,80,81,114 
,3,81,82,115 ,3,82,83,116 ,3,83,84,117 ,3,84,85,118 
,3,85,86,119 ,3,86,87,120 ,3,87,88,121 ,3,88,89,122 
,3,89,90,123 ,3,90,91,124 ,3,91,92,125 ,3,92,93,126 
,3,93,95,127 ,3,94,95,152 ,3,95,157,96 ,2,96,128 ,4,96,158,98,129 
,4,97,107,159,130 ,2,98,99 ,6,99,160,19,57,20,131 ,6,99,162,21,57,22,132 
,4,99,23,100,133 ,4,99,24,101,134 ,4,99,25,102,135 ,6,99,163,26,57,20,136 
,6,99,164,27,57,22,137 ,6,99,165,28,57,29,138 ,4,99,30,103,139 
,4,99,31,104,140 ,4,99,32,105,141 ,4,99,33,106,142 ,6,99,166,34,57,29,143 
,5,99,167,35,168,144 ,6,99,169,36,57,37,145 ,6,99,170,38,57,39,146 
,6,99,171,40,57,41,147 ,6,99,172,42,57,43,148 ,6,99,173,44,57,45,149 
,6,99,174,46,57,47,150 ,6,99,175,48,57,49,151 ,7,100,176,157,158,107,177,152 
,5,100,178,19,57,20 ,5,100,179,21,57,22 ,5,100,180,34,57,29 
,7,101,181,157,158,107,177,152 ,5,101,182,19,57,20 ,5,101,183,21,57,22 
,5,101,184,34,57,29 ,7,102,185,157,158,107,177,152 ,7,103,186,157,158,107,177,152 
,7,104,187,157,158,107,177,152 ,7,105,188,157,158,107,177,152 
,7,106,189,157,158,107,177,152 ,3,107,50,153 ,3,107,51,190 
,3,107,52,191 ,2,108,53 ,2,108,54 ,4,109,108,58,109 ,1,109 
,6,110,1,153,154,59,110 ,1,110 ,6,111,2,153,154,60,111 
,1,111 ,6,112,3,153,154,61,112 ,1,112 ,6,113,4,153,154,62,113 
,1,113 ,10,114,5,153,155,63,4,153,156,63,114 ,1,114 ,6,115,6,153,154,64,115 
,1,115 ,6,116,7,153,154,65,116 ,1,116 ,6,117,8,153,154,66,117 
,1,117 ,6,118,9,153,154,67,118 ,1,118 ,6,119,10,153,154,68,119 
,1,119 ,6,120,11,153,154,69,120 ,1,120 ,6,121,12,153,154,70,121 
,1,121 ,6,122,13,153,154,71,122 ,1,122 ,6,123,14,153,154,72,123 
,1,123 ,6,124,15,153,154,73,124 ,1,124 ,6,125,16,153,154,74,125 
,1,125 ,6,126,17,153,154,75,126 ,1,126 ,6,127,18,153,154,94,127 
,1,127 ,4,128,158,97,128 ,1,128 ,4,129,158,97,129 ,1,129 
,2,130,99 ,1,130 ,3,131,161,99 ,1,131 ,3,132,161,99 ,1,132 
,3,133,161,99 ,1,133 ,3,134,161,99 ,1,134 ,3,135,161,99 
,1,135 ,3,136,161,99 ,1,136 ,3,137,161,99 ,1,137 ,3,138,161,99 
,1,138 ,3,139,161,99 ,1,139 ,3,140,161,99 ,1,140 ,3,141,161,99 
,1,141 ,3,142,161,99 ,1,142 ,3,143,161,99 ,1,143 ,3,144,161,99 
,1,144 ,3,145,161,99 ,1,145 ,3,146,161,99 ,1,146 ,3,147,161,99 
,1,147 ,3,148,161,99 ,1,148 ,3,149,161,99 ,1,149 ,3,150,161,99 
,1,150 ,3,151,161,99 ,1,151 
,0};

private static int[] Production_row = {0

,1,4,8,12,16,20,24,28,32,36,40,44,48,52,56,60
,64,68,72,76,80,84,88,92,96,100,104,108,112,116,120,124
,128,132,136,140,144,148,152,156,160,163,168,173,176,183,190,195
,200,205,212,219,226,231,236,241,246,253,259,266,273,280,287,294
,301,308,316,322,328,334,342,348,354,360,368,376,384,392,400,404
,408,412,415,418,423,425,432,434,441,443,450,452,459,461,472,474
,481,483,490,492,499,501,508,510,517,519,526,528,535,537,544,546
,553,555,562,564,571,573,580,582,589,591,596,598,603,605,608,610
,614,616,620,622,626,628,632,634,638,640,644,646,650,652,656,658
,662,664,668,670,674,676,680,682,686,688,692,694,698,700,704,706
,710,712,716,718,722,724,728,730,734
,0};

private static short[] Parse = {

0,0,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2
,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2
,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,3,3
,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3
,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3
,3,3,3,3,3,3,3,3,3,3,3,3,3,4,4,4,4,4,4,4
,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4
,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4
,4,4,4,4,4,4,4,4,5,5,5,5,5,5,5,5,5,5,5,5
,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5
,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5
,5,5,5,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6
,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6
,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,7,7
,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7
,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7
,7,7,7,7,7,7,7,7,7,7,7,7,7,8,8,8,8,8,8,8
,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8
,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8
,8,8,8,8,8,8,8,8,9,9,9,9,9,9,9,9,9,9,9,9
,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9
,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9
,9,9,9,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10
,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10
,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,11,11
,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11
,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11
,11,11,11,11,11,11,11,11,11,11,11,11,11,12,12,12,12,12,12,12
,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12
,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12
,12,12,12,12,12,12,12,12,13,13,13,13,13,13,13,13,13,13,13,13
,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13
,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13
,13,13,13,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14
,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14
,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,15,15
,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15
,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15,15
,15,15,15,15,15,15,15,15,15,15,15,15,15,16,16,16,16,16,16,16
,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16
,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16,16
,16,16,16,16,16,16,16,16,17,17,17,17,17,17,17,17,17,17,17,17
,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17
,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17
,17,17,17,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18
,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18
,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,18,19,19
,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19
,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19,19
,19,19,19,19,19,19,19,19,19,19,19,19,19,20,20,20,20,20,20,20
,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20
,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20
,20,20,20,20,20,20,20,20,21,21,21,21,21,21,21,21,21,21,21,21
,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21
,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21
,21,21,21,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22
,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22
,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,23,23
,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23
,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23
,23,23,23,23,23,23,23,23,23,23,23,23,23,24,24,24,24,24,24,24
,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24
,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24
,24,24,24,24,24,24,24,24,25,25,25,25,25,25,25,25,25,25,25,25
,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25
,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25
,25,25,25,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26
,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26
,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26,26,27,27
,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27
,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27
,27,27,27,27,27,27,27,27,27,27,27,27,27,28,28,28,28,28,28,28
,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28
,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28,28
,28,28,28,28,28,28,28,28,29,29,29,29,29,29,29,29,29,29,29,29
,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29
,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29,29
,29,29,29,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30
,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30
,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,31,31
,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31
,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31,31
,31,31,31,31,31,31,31,31,31,31,31,31,31,32,32,32,32,32,32,32
,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32
,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32
,32,32,32,32,32,32,32,32,33,33,33,33,33,33,33,33,33,33,33,33
,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33
,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33,33
,33,33,33,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34
,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34
,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,34,35,35
,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35
,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35
,35,35,35,35,35,35,35,35,35,35,35,35,35,36,36,36,36,36,36,36
,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36
,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36,36
,36,36,36,36,36,36,36,36,37,37,37,37,37,37,37,37,37,37,37,37
,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37
,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37,37
,37,37,37,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38
,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38
,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,39,39
,39,39,39,39,39,39,39,39,39,39,39,39,39,39,39,39,39,39,39,39
,39,39,39,39,39,39,39,39,39,39,39,39,39,39,39,39,39,39,39,39
,39,39,39,39,39,39,39,39,39,39,39,39,39,40,40,40,40,40,40,40
,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40
,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40
,40,40,40,40,40,40,40,40,41,41,41,41,41,41,41,41,41,41,41,41
,41,41,41,41,41,41,42,41,42,41,42,42,42,42,42,42,41,42,42,42
,42,42,42,42,41,42,41,42,41,42,41,42,41,42,41,42,41,41,41,41
,41,41,41,127,127,127,127,127,127,127,127,127,127,127,127,127,127,127,127,127
,127,126,127,126,127,126,126,126,126,126,126,127,126,126,126,126,126,126,126,127
,126,127,126,127,126,127,126,127,126,127,126,127,127,127,127,127,127,127,129,129
,129,129,129,129,129,129,129,129,129,129,129,129,129,129,129,129,128,129,128,129
,128,128,128,128,128,128,129,128,128,128,128,128,128,128,129,128,129,128,129,128
,129,128,129,128,129,128,129,129,129,129,129,129,129,131,131,131,131,131,131,131
,131,131,131,131,131,131,131,131,131,131,131,130,131,130,131,130,130,130,130,130
,130,131,130,130,130,130,130,130,130,131,130,131,130,131,130,131,130,131,130,131
,130,131,131,131,131,131,131,131,133,133,133,133,133,133,133,133,133,133,133,133
,133,133,133,133,133,133,132,133,132,133,132,132,132,132,132,132,133,132,132,132
,132,132,132,132,133,132,133,132,133,132,133,132,133,132,133,132,133,133,133,133
,133,133,133,135,135,135,135,135,135,135,135,135,135,135,135,135,135,135,135,135
,135,134,135,134,135,134,134,134,134,134,134,135,134,134,134,134,134,134,134,135
,134,135,134,135,134,135,134,135,134,135,134,135,135,135,135,135,135,135,137,137
,137,137,137,137,137,137,137,137,137,137,137,137,137,137,137,137,136,137,136,137
,136,136,136,136,136,136,137,136,136,136,136,136,136,136,137,136,137,136,137,136
,137,136,137,136,137,136,137,137,137,137,137,137,137,139,139,139,139,139,139,139
,139,139,139,139,139,139,139,139,139,139,139,138,139,138,139,138,138,138,138,138
,138,139,138,138,138,138,138,138,138,139,138,139,138,139,138,139,138,139,138,139
,138,139,139,139,139,139,139,139,141,141,141,141,141,141,141,141,141,141,141,141
,141,141,141,141,141,141,140,141,140,141,140,140,140,140,140,140,141,140,140,140
,140,140,140,140,141,140,141,140,141,140,141,140,141,140,141,140,141,141,141,141
,141,141,141,143,143,143,143,143,143,143,143,143,143,143,143,143,143,143,143,143
,143,142,143,142,143,142,142,142,142,142,142,143,142,142,142,142,142,142,142,143
,142,143,142,143,142,143,142,143,142,143,142,143,143,143,143,143,143,143,145,145
,145,145,145,145,145,145,145,145,145,145,145,145,145,145,145,145,144,145,144,145
,144,144,144,144,144,144,145,144,144,144,144,144,144,144,145,144,145,144,145,144
,145,144,145,144,145,144,145,145,145,145,145,145,145,147,147,147,147,147,147,147
,147,147,147,147,147,147,147,147,147,147,147,146,147,146,147,146,146,146,146,146
,146,147,146,146,146,146,146,146,146,147,146,147,146,147,146,147,146,147,146,147
,146,147,147,147,147,147,147,147,149,149,149,149,149,149,149,149,149,149,149,149
,149,149,149,149,149,149,148,149,148,149,148,148,148,148,148,148,149,148,148,148
,148,148,148,148,149,148,149,148,149,148,149,148,149,148,149,148,149,149,149,149
,149,149,149,151,151,151,151,151,151,151,151,151,151,151,151,151,151,151,151,151
,151,150,151,150,151,150,150,150,150,150,150,151,150,150,150,150,150,150,150,151
,150,151,150,151,150,151,150,151,150,151,150,151,151,151,151,151,151,151,153,153
,153,153,153,153,153,153,153,153,153,153,153,153,153,153,153,153,152,153,152,153
,152,152,152,152,152,152,153,152,152,152,152,152,152,152,153,152,153,152,153,152
,153,152,153,152,153,152,153,153,153,153,153,153,153,155,155,155,155,155,155,155
,155,155,155,155,155,155,155,155,155,155,155,154,155,154,155,154,154,154,154,154
,154,155,154,154,154,154,154,154,154,155,154,155,154,155,154,155,154,155,154,155
,154,155,155,155,155,155,155,155,157,157,157,157,157,157,157,157,157,157,157,157
,157,157,157,157,157,157,156,157,156,157,156,156,156,156,156,156,157,156,156,156
,156,156,156,156,157,156,157,156,157,156,157,156,157,156,157,156,157,157,157,157
,157,157,157,159,159,159,159,159,159,159,159,159,159,159,159,159,159,159,159,159
,159,158,159,158,159,158,158,158,158,158,158,159,158,158,158,158,158,158,158,159
,158,159,158,159,158,159,158,159,158,159,158,159,159,159,159,159,159,159,161,161
,161,161,161,161,161,161,161,161,161,161,161,161,161,161,161,161,160,161,160,161
,160,160,160,160,160,160,161,160,160,160,160,160,160,160,161,160,161,160,161,160
,161,160,161,160,161,160,161,161,161,161,161,161,161,163,163,163,163,163,163,163
,163,163,163,163,163,163,163,163,163,163,163,162,163,162,163,162,162,162,162,162
,162,163,162,162,162,162,162,162,162,163,162,163,162,163,162,163,162,163,162,163
,162,163,163,163,163,163,163,163,165,165,165,165,165,165,165,165,165,165,165,165
,165,165,165,165,165,165,164,165,164,165,164,164,164,164,164,164,165,164,164,164
,164,164,164,164,165,164,165,164,165,164,165,164,165,164,165,164,165,165,165,165
,165,165,165,167,167,167,167,167,167,167,167,167,167,167,167,167,167,167,167,167
,167,166,167,166,167,166,166,166,166,166,166,167,166,166,166,166,166,166,166,167
,166,167,166,167,166,167,166,167,166,167,166,167,167,167,167,167,167,167,169,169
,169,169,169,169,169,169,169,169,169,169,169,169,169,169,169,169,168,169,168,169
,168,168,168,168,168,168,169,168,168,168,168,168,168,168,169,168,169,168,169,168
,169,168,169,168,169,168,169,169,169,169,169,169,169,1,1,1,1,1,1,1
,1,1,1,1,1,1,1,1,1,1,1,1,0,1,0,1,1,1,1,1
,1,0,1,1,1,1,1,1,1,0,1,0,1,0,1,0,1,0,1,0
,1,0,1,1,1,1,1,1,123,123,123,123,123,123,123,123,123,123,123,123
,123,123,123,123,123,123,44,123,44,123,44,44,44,44,44,44,123,44,44,44
,44,44,44,44,123,44,123,44,123,44,123,44,123,44,123,44,123,122,122,122
,123,123,123,125,125,125,125,125,125,125,125,125,125,125,125,125,125,125,125,125
,125,45,125,46,125,47,48,49,50,51,52,125,53,54,55,56,57,58,59,125
,60,125,61,125,62,125,63,125,64,125,65,125,124,124,124,125,125,125,121,121
,121,121,121,121,121,121,121,121,121,121,121,121,121,121,121,120,67,121,68,121
,43,43,43,74,74,74,121,75,75,75,0,69,82,83,121,0,121,0,121,0
,121,0,121,0,121,0,121,66,66,66,121,121,121,119,119,119,119,119,119,119
,119,119,119,119,119,119,119,119,119,118,0,71,119,72,119,76,76,76,77,77
,77,119,78,78,78,0,73,0,0,119,0,119,0,119,0,119,0,119,0,119
,0,119,70,70,70,119,119,119,117,117,117,117,117,117,117,117,117,117,117,117
,117,117,117,116,85,0,85,117,0,117,79,80,81,85,0,0,117,0,0,0
,0,85,0,85,117,85,117,85,117,85,117,85,117,85,117,0,117,84,84,85
,117,117,117,115,115,115,115,115,115,115,115,115,115,115,115,115,115,114,0,0
,0,0,115,0,115,0,0,0,0,0,0,115,0,0,0,0,0,0,0,115
,0,115,0,115,0,115,0,115,0,115,0,115,0,0,0,115,115,115,113,113
,113,113,113,113,113,113,113,113,113,113,113,112,0,0,0,0,0,113,0,113
,0,0,0,0,0,0,113,0,0,0,0,0,0,0,113,0,113,0,113,0
,113,0,113,0,113,0,113,0,0,0,113,113,113,111,111,111,111,111,111,111
,111,111,111,111,111,110,0,0,0,0,0,0,111,0,111,0,0,0,0,0
,0,111,0,0,0,0,0,0,0,111,0,111,0,111,0,111,0,111,0,111
,0,111,0,0,0,111,111,111,109,109,109,109,109,109,109,109,109,109,109,108
,0,0,0,0,0,0,0,109,0,109,0,0,0,0,0,0,109,0,0,0
,0,0,0,0,109,0,109,0,109,0,109,0,109,0,109,0,109,0,0,0
,109,109,109,107,107,107,107,107,107,107,107,107,107,106,0,0,0,0,0,0
,0,0,107,0,107,0,0,0,0,0,0,107,0,0,0,0,0,0,0,107
,0,107,0,107,0,107,0,107,0,107,0,107,0,0,0,107,107,107,105,105
,105,105,105,105,105,105,105,104,0,0,0,0,0,0,0,0,0,105,0,105
,0,0,0,0,0,0,105,0,0,0,0,0,0,0,105,0,105,0,105,0
,105,0,105,0,105,0,105,0,0,0,105,105,105,103,103,103,103,103,103,103
,103,102,0,0,0,0,0,0,0,0,0,0,103,0,103,0,0,0,0,0
,0,103,0,0,0,0,0,0,0,103,0,103,0,103,0,103,0,103,0,103
,0,103,0,0,0,103,103,103,101,101,101,101,101,101,101,100,0,0,0,0
,0,0,0,0,0,0,0,101,0,101,0,0,0,0,0,0,101,0,0,0
,0,0,0,0,101,0,101,0,101,0,101,0,101,0,101,0,101,0,0,0
,101,101,101,99,99,99,99,99,99,98,0,0,0,0,0,0,0,0,0,0
,0,0,99,0,99,97,97,97,97,97,96,99,0,0,0,0,0,0,0,99
,0,99,0,99,97,99,97,99,0,99,0,99,0,97,0,99,99,99,0,0
,0,97,0,97,0,97,0,97,0,97,0,97,0,97,0,0,0,97,97,97
,95,95,95,95,94,0,0,0,0,0,0,0,0,0,0,0,0,0,0,95
,0,95,93,93,93,92,0,0,95,0,0,0,0,0,0,0,95,0,95,0
,95,93,95,93,95,0,95,0,95,0,93,0,95,95,95,0,0,0,93,0
,93,0,93,0,93,0,93,0,93,0,93,91,91,90,93,93,93,0,0,0
,0,0,0,0,0,0,0,0,0,0,91,0,91,89,88,0,0,0,0,91
,0,0,0,0,0,0,0,91,0,91,0,91,89,91,89,91,0,91,0,91
,0,89,0,91,91,91,0,0,0,89,86,89,0,89,0,89,0,89,0,89
,0,89,0,0,0,89,89,89,0,87,0,87,0,0,0,0,0,0,87,0
,0,0,0,0,0,0,87,0,87,0,87,0,87,0,87,0,87,0,87,0
,0,0,87,87,87
};

private static int[] Parse_row = {0

,3411,1,56,111,166,221,276,331,386,441,496,551,606,661,716,771
,826,881,936,991,1046,1101,1156,1211,1266,1321,1376,1431,1486,1541,1596,1651
,1706,1761,1816,1871,1926,1981,2036,2091,2146,3549,3466,3521,3576,3631,3552,3556
,3604,3607,3611,3659,3558,3683,4388,4351,4329,4280,4258,4203,4181,4126,4071,4016
,3961,3906,3851,3796,3741,3686,3631,3576,3466,3521,2201,2256,2311,2366,2421,2476
,2531,2586,2641,2696,2751,2806,2861,2916,2971,3026,3081,3136,3191,3246,3301,3356

,0};

private static short[] Conflict = {

0
};

private static int[] Conflict_row = {0


,0};

private static short get_conditional_production ( short symbol ) { return (short) 0; }

private const short   END_OF_SLK_INPUT_ = 55;
private const short   START_SYMBOL = 56;
private const short   START_STATE = 0;
private const short   START_CONFLICT = 170;
private const short   END_CONFLICT = 170;
private const short   START_ACTION = 152;
private const short   END_ACTION = 192;
private const short   TOTAL_CONFLICTS = 0;

public const int   NOT_A_SYMBOL = 0;
public const int   NONTERMINAL_SYMBOL = 1;
public const int   TERMINAL_SYMBOL = 2;
public const int   ACTION_SYMBOL = 3;

public static short[]
GetProductionArray ( short  production_number )
{
   short   index = (short)  Production_row [ production_number ],
           array_length = (short)  Production [ index ],
           new_index = 0;
   short[] productionArray = new short[17];        

   while ( array_length-- >= 0 ) {
       productionArray [ new_index++ ] = Production [ index++ ];
   }
   return  productionArray;
}

public static int GetSymbolType ( short   symbol )
{
   int   symbol_type = NOT_A_SYMBOL;

   if ( symbol >= START_ACTION  &&  symbol < END_ACTION ) {
       symbol_type = ACTION_SYMBOL;
   } else if ( symbol >= START_SYMBOL ) {
       symbol_type = NONTERMINAL_SYMBOL;
   } else if ( symbol > 0 ) {
       symbol_type = TERMINAL_SYMBOL;
   }
   return  symbol_type;
}

public static bool    IsNonterminal ( short   symbol )
{
   return ( symbol >= START_SYMBOL  &&  symbol < START_ACTION );
}

public static bool    IsTerminal ( short   symbol )
{
   return ( symbol > 0  &&  symbol < START_SYMBOL );
}

public static bool    IsAction ( short   symbol )
{
   return ( symbol >= START_ACTION  &&  symbol < END_ACTION );
}

public static short GetTerminalIndex ( short   token ){
 return ( token );
}

public static short
get_production ( short     conflict_number,
                 DslToken  tokens )
{
    short   entry = 0;
    int     index, level;

    if ( conflict_number <= TOTAL_CONFLICTS ) {
        entry = (short) ( conflict_number + (START_CONFLICT - 1) );
        level = 1;
        while ( entry >= START_CONFLICT ) {
            index = Conflict_row [entry - (START_CONFLICT -1)];
            index += tokens.peek ( level );
            entry = Conflict [ index ];
            ++level;
        }
    }

    return  entry;
}

private static short
get_predicted_entry ( DslToken   tokens,
                      short      production_number,
                      short      token,
                      int        scan_level,
                      int        depth )
{
 return  0;
}

        internal unsafe static void
        parse(ref DslAction action,
                ref DslToken tokens,
                ref DslError error,
                short start_symbol)
        {
            short lhs;
            short production_number, entry, symbol, token, new_token;
            int production_length, top, index, level;
            
            short* stack = stackalloc short[65535];

            top = 65534;
            stack[top] = 0;
            if (start_symbol == 0) {
                start_symbol = START_SYMBOL;
            }
            if (top > 0) {
                stack[--top] = start_symbol;
            } else { error.message("DslParse: stack overflow\n", ref tokens); return; }
            token = tokens.get();
            new_token = token;

            for (symbol = (stack[top] != 0 ? stack[top++] : (short)0); symbol != 0; ) {

                if (symbol >= START_ACTION) {
                    action.execute(symbol - (START_ACTION - 1));

                } else if (symbol >= START_SYMBOL) {
                    entry = 0;
                    level = 1;
                    production_number = get_conditional_production(symbol);
                    if (production_number != 0) {
                        entry = get_predicted_entry(tokens,
                                                      production_number, token,
                                                      level, 1);
                    }
                    if (entry == 0) {
                        index = Parse_row[symbol - (START_SYMBOL - 1)];
                        index += token;
                        entry = Parse[index];
                    }
                    while (entry >= START_CONFLICT) {
                        index = Conflict_row[entry - (START_CONFLICT - 1)];
                        index += tokens.peek(level);
                        entry = Conflict[index];
                        ++level;
                    }
                    if (entry != 0) {
                        index = Production_row[entry];
                        production_length = Production[index] - 1;
                        lhs = Production[++index];
                        if (lhs == symbol) {
                            action.predict(entry, token, tokens.getLastToken(), tokens.getLastLineNumber(), tokens.getCurToken(), tokens.getLineNumber());
                            index += production_length;
                            for (; production_length-- > 0; --index) {
                                if (top > 0) {
                                    stack[--top] = Production[index];
                                } else { error.message("DslParse: stack overflow\n", ref tokens); return; }
                            }
                        } else {
                            action.predict(entry, token, tokens.getLastToken(), tokens.getLastLineNumber(), tokens.getCurToken(), tokens.getLineNumber());
                            new_token = error.no_entry(symbol, token, level - 1, ref tokens);
                        }
                    } else { // no table entry
                        action.predict(entry, token, tokens.getLastToken(), tokens.getLastLineNumber(), tokens.getCurToken(), tokens.getLineNumber());
                        new_token = error.no_entry(symbol, token, level - 1, ref tokens);
                    }
                } else if (symbol > 0) {
                    if (symbol == token) {
                        token = tokens.get();
                        new_token = token;
                    } else {
                        new_token = error.mismatch(symbol, token, ref tokens);
                    }
                } else {
                    error.message("\n parser error: symbol value 0\n", ref tokens);
                }
                if (token != new_token) {
                    if (new_token != 0) {
                        token = new_token;
                    }
                    if (token != END_OF_SLK_INPUT_) {
                        continue;
                    }
                }
                symbol = (stack[top] != 0 ? stack[top++] : (short)0);
            }
            if (token != END_OF_SLK_INPUT_) {
                error.input_left(ref tokens);
            }
        }
    };
}
