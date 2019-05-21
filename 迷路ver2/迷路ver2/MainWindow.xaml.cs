using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 迷路ver2
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            Random rand = new Random();
            int size = 10;
            int[] direction = new int[522];

            for (int i = 0; i < 522; i++)
            {
                direction[i] = rand.Next(2);
            }

            if (direction[0] == 1) { label_Copy.Width += size; }
            else { label_Copy.Height += size; }

            if (direction[1] == 1) { label_Copy1.Width += size; }
            else { label_Copy1.Height += size; }

            if (direction[2] == 1) { label_Copy2.Width += size; }
            else { label_Copy2.Height += size; }

            if (direction[3] == 1) { label_Copy3.Width += size; }
            else { label_Copy3.Height += size; }

            if (direction[4] == 1) { label_Copy4.Width += size; }
            else { label_Copy4.Height += size; }

            if (direction[5] == 1) { label_Copy5.Width += size; }
            else { label_Copy5.Height += size; }

            if (direction[6] == 1) { label_Copy6.Width += size; }
            else { label_Copy6.Height += size; }

            if (direction[7] == 1) { label_Copy7.Width += size; }
            else { label_Copy7.Height += size; }

            if (direction[8] == 1) { label_Copy8.Width += size; }
            else { label_Copy8.Height += size; }

            if (direction[9] == 1) { label_Copy9.Width += size; }
            else { label_Copy9.Height += size; }

            if (direction[10] == 1) { label_Copy10.Width += size; }
            else { label_Copy10.Height += size; }

            if (direction[11] == 1) { label_Copy11.Width += size; }
            else { label_Copy11.Height += size; }

            if (direction[12] == 1) { label_Copy12.Width += size; }
            else { label_Copy12.Height += size; }

            if (direction[13] == 1) { label_Copy13.Width += size; }
            else { label_Copy13.Height += size; }

            if (direction[14] == 1) { label_Copy14.Width += size; }
            else { label_Copy14.Height += size; }

            if (direction[15] == 1) { label_Copy15.Width += size; }
            else { label_Copy15.Height += size; }

            if (direction[16] == 1) { label_Copy16.Width += size; }
            else { label_Copy16.Height += size; }

            if (direction[17] == 1) { label_Copy17.Width += size; }
            else { label_Copy17.Height += size; }

            if (direction[18] == 1) { label_Copy18.Width += size; }
            else { label_Copy18.Height += size; }

            if (direction[19] == 1) { label_Copy19.Width += size; }
            else { label_Copy19.Height += size; }

            if (direction[20] == 1) { label_Copy20.Width += size; }
            else { label_Copy20.Height += size; }

            if (direction[21] == 1) { label_Copy21.Width += size; }
            else { label_Copy21.Height += size; }

            if (direction[22] == 1) { label_Copy22.Width += size; }
            else { label_Copy22.Height += size; }

            if (direction[23] == 1) { label_Copy23.Width += size; }
            else { label_Copy23.Height += size; }

            if (direction[24] == 1) { label_Copy24.Width += size; }
            else { label_Copy24.Height += size; }

            if (direction[25] == 1) { label_Copy25.Width += size; }
            else { label_Copy25.Height += size; }

            if (direction[26] == 1) { label_Copy26.Width += size; }
            else { label_Copy26.Height += size; }

            if (direction[27] == 1) { label_Copy27.Width += size; }
            else { label_Copy27.Height += size; }

            if (direction[28] == 1) { label_Copy28.Width += size; }
            else { label_Copy28.Height += size; }

            if (direction[29] == 1) { label_Copy29.Width += size; }
            else { label_Copy29.Height += size; }

            if (direction[30] == 1) { label_Copy30.Width += size; }
            else { label_Copy30.Height += size; }

            if (direction[31] == 1) { label_Copy31.Width += size; }
            else { label_Copy31.Height += size; }

            if (direction[32] == 1) { label_Copy32.Width += size; }
            else { label_Copy32.Height += size; }

            if (direction[33] == 1) { label_Copy33.Width += size; }
            else { label_Copy33.Height += size; }

            if (direction[34] == 1) { label_Copy34.Width += size; }
            else { label_Copy34.Height += size; }

            if (direction[35] == 1) { label_Copy35.Width += size; }
            else { label_Copy35.Height += size; }

            if (direction[36] == 1) { label_Copy36.Width += size; }
            else { label_Copy36.Height += size; }

            if (direction[37] == 1) { label_Copy37.Width += size; }
            else { label_Copy37.Height += size; }

            if (direction[38] == 1) { label_Copy38.Width += size; }
            else { label_Copy38.Height += size; }

            if (direction[39] == 1) { label_Copy39.Width += size; }
            else { label_Copy39.Height += size; }

            if (direction[40] == 1) { label_Copy40.Width += size; }
            else { label_Copy40.Height += size; }

            if (direction[41] == 1) { label_Copy41.Width += size; }
            else { label_Copy41.Height += size; }

            if (direction[42] == 1) { label_Copy42.Width += size; }
            else { label_Copy42.Height += size; }

            if (direction[43] == 1) { label_Copy43.Width += size; }
            else { label_Copy43.Height += size; }

            if (direction[44] == 1) { label_Copy44.Width += size; }
            else { label_Copy44.Height += size; }

            if (direction[45] == 1) { label_Copy45.Width += size; }
            else { label_Copy45.Height += size; }

            if (direction[46] == 1) { label_Copy46.Width += size; }
            else { label_Copy46.Height += size; }

            if (direction[47] == 1) { label_Copy47.Width += size; }
            else { label_Copy47.Height += size; }

            if (direction[48] == 1) { label_Copy48.Width += size; }
            else { label_Copy48.Height += size; }

            if (direction[49] == 1) { label_Copy49.Width += size; }
            else { label_Copy49.Height += size; }

            if (direction[50] == 1) { label_Copy50.Width += size; }
            else { label_Copy50.Height += size; }

            if (direction[51] == 1) { label_Copy51.Width += size; }
            else { label_Copy51.Height += size; }

            if (direction[52] == 1) { label_Copy52.Width += size; }
            else { label_Copy52.Height += size; }

            if (direction[53] == 1) { label_Copy53.Width += size; }
            else { label_Copy53.Height += size; }

            if (direction[54] == 1) { label_Copy54.Width += size; }
            else { label_Copy54.Height += size; }

            if (direction[55] == 1) { label_Copy55.Width += size; }
            else { label_Copy55.Height += size; }

            if (direction[56] == 1) { label_Copy56.Width += size; }
            else { label_Copy56.Height += size; }

            if (direction[57] == 1) { label_Copy57.Width += size; }
            else { label_Copy57.Height += size; }

            if (direction[58] == 1) { label_Copy58.Width += size; }
            else { label_Copy58.Height += size; }

            if (direction[59] == 1) { label_Copy59.Width += size; }
            else { label_Copy59.Height += size; }

            if (direction[60] == 1) { label_Copy60.Width += size; }
            else { label_Copy60.Height += size; }

            if (direction[61] == 1) { label_Copy61.Width += size; }
            else { label_Copy61.Height += size; }

            if (direction[62] == 1) { label_Copy62.Width += size; }
            else { label_Copy62.Height += size; }

            if (direction[63] == 1) { label_Copy63.Width += size; }
            else { label_Copy63.Height += size; }

            if (direction[64] == 1) { label_Copy64.Width += size; }
            else { label_Copy64.Height += size; }

            if (direction[65] == 1) { label_Copy65.Width += size; }
            else { label_Copy65.Height += size; }

            if (direction[66] == 1) { label_Copy66.Width += size; }
            else { label_Copy66.Height += size; }

            if (direction[67] == 1) { label_Copy67.Width += size; }
            else { label_Copy67.Height += size; }

            if (direction[68] == 1) { label_Copy68.Width += size; }
            else { label_Copy68.Height += size; }

            if (direction[69] == 1) { label_Copy69.Width += size; }
            else { label_Copy69.Height += size; }

            if (direction[70] == 1) { label_Copy70.Width += size; }
            else { label_Copy70.Height += size; }

            if (direction[71] == 1) { label_Copy71.Width += size; }
            else { label_Copy71.Height += size; }

            if (direction[72] == 1) { label_Copy72.Width += size; }
            else { label_Copy72.Height += size; }

            if (direction[73] == 1) { label_Copy73.Width += size; }
            else { label_Copy73.Height += size; }

            if (direction[74] == 1) { label_Copy74.Width += size; }
            else { label_Copy74.Height += size; }

            if (direction[75] == 1) { label_Copy75.Width += size; }
            else { label_Copy75.Height += size; }

            if (direction[76] == 1) { label_Copy76.Width += size; }
            else { label_Copy76.Height += size; }

            if (direction[77] == 1) { label_Copy77.Width += size; }
            else { label_Copy77.Height += size; }

            if (direction[78] == 1) { label_Copy78.Width += size; }
            else { label_Copy78.Height += size; }

            if (direction[79] == 1) { label_Copy79.Width += size; }
            else { label_Copy79.Height += size; }

            if (direction[80] == 1) { label_Copy80.Width += size; }
            else { label_Copy80.Height += size; }

            if (direction[81] == 1) { label_Copy81.Width += size; }
            else { label_Copy81.Height += size; }

            if (direction[82] == 1) { label_Copy82.Width += size; }
            else { label_Copy82.Height += size; }

            if (direction[83] == 1) { label_Copy83.Width += size; }
            else { label_Copy83.Height += size; }

            if (direction[84] == 1) { label_Copy84.Width += size; }
            else { label_Copy84.Height += size; }

            if (direction[85] == 1) { label_Copy85.Width += size; }
            else { label_Copy85.Height += size; }

            if (direction[86] == 1) { label_Copy86.Width += size; }
            else { label_Copy86.Height += size; }

            if (direction[87] == 1) { label_Copy87.Width += size; }
            else { label_Copy87.Height += size; }

            if (direction[88] == 1) { label_Copy88.Width += size; }
            else { label_Copy88.Height += size; }

            if (direction[89] == 1) { label_Copy89.Width += size; }
            else { label_Copy89.Height += size; }

            if (direction[90] == 1) { label_Copy90.Width += size; }
            else { label_Copy90.Height += size; }

            if (direction[91] == 1) { label_Copy91.Width += size; }
            else { label_Copy91.Height += size; }

            if (direction[92] == 1) { label_Copy92.Width += size; }
            else { label_Copy92.Height += size; }

            if (direction[93] == 1) { label_Copy93.Width += size; }
            else { label_Copy93.Height += size; }

            if (direction[94] == 1) { label_Copy94.Width += size; }
            else { label_Copy94.Height += size; }

            if (direction[95] == 1) { label_Copy95.Width += size; }
            else { label_Copy95.Height += size; }

            if (direction[96] == 1) { label_Copy96.Width += size; }
            else { label_Copy96.Height += size; }

            if (direction[97] == 1) { label_Copy97.Width += size; }
            else { label_Copy97.Height += size; }

            if (direction[98] == 1) { label_Copy98.Width += size; }
            else { label_Copy98.Height += size; }

            if (direction[99] == 1) { label_Copy99.Width += size; }
            else { label_Copy99.Height += size; }

            if (direction[100] == 1) { label_Copy100.Width += size; }
            else { label_Copy100.Height += size; }

            if (direction[101] == 1) { label_Copy101.Width += size; }
            else { label_Copy101.Height += size; }

            if (direction[102] == 1) { label_Copy102.Width += size; }
            else { label_Copy102.Height += size; }

            if (direction[103] == 1) { label_Copy103.Width += size; }
            else { label_Copy103.Height += size; }

            if (direction[104] == 1) { label_Copy104.Width += size; }
            else { label_Copy104.Height += size; }

            if (direction[105] == 1) { label_Copy105.Width += size; }
            else { label_Copy105.Height += size; }

            if (direction[106] == 1) { label_Copy106.Width += size; }
            else { label_Copy106.Height += size; }

            if (direction[107] == 1) { label_Copy107.Width += size; }
            else { label_Copy107.Height += size; }

            if (direction[108] == 1) { label_Copy108.Width += size; }
            else { label_Copy108.Height += size; }

            if (direction[109] == 1) { label_Copy109.Width += size; }
            else { label_Copy109.Height += size; }

            if (direction[110] == 1) { label_Copy110.Width += size; }
            else { label_Copy110.Height += size; }

            if (direction[111] == 1) { label_Copy111.Width += size; }
            else { label_Copy111.Height += size; }

            if (direction[112] == 1) { label_Copy112.Width += size; }
            else { label_Copy112.Height += size; }

            if (direction[113] == 1) { label_Copy113.Width += size; }
            else { label_Copy113.Height += size; }

            if (direction[114] == 1) { label_Copy114.Width += size; }
            else { label_Copy114.Height += size; }

            if (direction[115] == 1) { label_Copy115.Width += size; }
            else { label_Copy115.Height += size; }

            if (direction[116] == 1) { label_Copy116.Width += size; }
            else { label_Copy116.Height += size; }

            if (direction[117] == 1) { label_Copy117.Width += size; }
            else { label_Copy117.Height += size; }

            if (direction[118] == 1) { label_Copy118.Width += size; }
            else { label_Copy118.Height += size; }

            if (direction[119] == 1) { label_Copy119.Width += size; }
            else { label_Copy119.Height += size; }

            if (direction[120] == 1) { label_Copy120.Width += size; }
            else { label_Copy120.Height += size; }

            if (direction[121] == 1) { label_Copy121.Width += size; }
            else { label_Copy121.Height += size; }

            if (direction[122] == 1) { label_Copy122.Width += size; }
            else { label_Copy122.Height += size; }

            if (direction[123] == 1) { label_Copy123.Width += size; }
            else { label_Copy123.Height += size; }

            if (direction[124] == 1) { label_Copy124.Width += size; }
            else { label_Copy124.Height += size; }

            if (direction[125] == 1) { label_Copy125.Width += size; }
            else { label_Copy125.Height += size; }

            if (direction[126] == 1) { label_Copy126.Width += size; }
            else { label_Copy126.Height += size; }

            if (direction[127] == 1) { label_Copy127.Width += size; }
            else { label_Copy127.Height += size; }

            if (direction[128] == 1) { label_Copy128.Width += size; }
            else { label_Copy128.Height += size; }

            if (direction[129] == 1) { label_Copy129.Width += size; }
            else { label_Copy129.Height += size; }

            if (direction[130] == 1) { label_Copy130.Width += size; }
            else { label_Copy130.Height += size; }

            if (direction[131] == 1) { label_Copy131.Width += size; }
            else { label_Copy131.Height += size; }

            if (direction[132] == 1) { label_Copy132.Width += size; }
            else { label_Copy132.Height += size; }

            if (direction[133] == 1) { label_Copy133.Width += size; }
            else { label_Copy133.Height += size; }

            if (direction[134] == 1) { label_Copy134.Width += size; }
            else { label_Copy134.Height += size; }

            if (direction[135] == 1) { label_Copy135.Width += size; }
            else { label_Copy135.Height += size; }

            if (direction[136] == 1) { label_Copy136.Width += size; }
            else { label_Copy136.Height += size; }

            if (direction[137] == 1) { label_Copy137.Width += size; }
            else { label_Copy137.Height += size; }

            if (direction[138] == 1) { label_Copy138.Width += size; }
            else { label_Copy138.Height += size; }

            if (direction[139] == 1) { label_Copy139.Width += size; }
            else { label_Copy139.Height += size; }

            if (direction[140] == 1) { label_Copy140.Width += size; }
            else { label_Copy140.Height += size; }

            if (direction[141] == 1) { label_Copy141.Width += size; }
            else { label_Copy141.Height += size; }

            if (direction[142] == 1) { label_Copy142.Width += size; }
            else { label_Copy142.Height += size; }

            if (direction[143] == 1) { label_Copy143.Width += size; }
            else { label_Copy143.Height += size; }

            if (direction[144] == 1) { label_Copy144.Width += size; }
            else { label_Copy144.Height += size; }

            if (direction[145] == 1) { label_Copy145.Width += size; }
            else { label_Copy145.Height += size; }

            if (direction[146] == 1) { label_Copy146.Width += size; }
            else { label_Copy146.Height += size; }

            if (direction[147] == 1) { label_Copy147.Width += size; }
            else { label_Copy147.Height += size; }

            if (direction[148] == 1) { label_Copy148.Width += size; }
            else { label_Copy148.Height += size; }

            if (direction[149] == 1) { label_Copy149.Width += size; }
            else { label_Copy149.Height += size; }

            if (direction[150] == 1) { label_Copy150.Width += size; }
            else { label_Copy150.Height += size; }

            if (direction[151] == 1) { label_Copy151.Width += size; }
            else { label_Copy151.Height += size; }

            if (direction[152] == 1) { label_Copy152.Width += size; }
            else { label_Copy152.Height += size; }

            if (direction[153] == 1) { label_Copy153.Width += size; }
            else { label_Copy153.Height += size; }

            if (direction[154] == 1) { label_Copy154.Width += size; }
            else { label_Copy154.Height += size; }

            if (direction[155] == 1) { label_Copy155.Width += size; }
            else { label_Copy155.Height += size; }

            if (direction[156] == 1) { label_Copy156.Width += size; }
            else { label_Copy156.Height += size; }

            if (direction[157] == 1) { label_Copy157.Width += size; }
            else { label_Copy157.Height += size; }

            if (direction[158] == 1) { label_Copy158.Width += size; }
            else { label_Copy158.Height += size; }

            if (direction[159] == 1) { label_Copy159.Width += size; }
            else { label_Copy159.Height += size; }

            if (direction[160] == 1) { label_Copy160.Width += size; }
            else { label_Copy160.Height += size; }

            if (direction[161] == 1) { label_Copy161.Width += size; }
            else { label_Copy161.Height += size; }

            if (direction[162] == 1) { label_Copy162.Width += size; }
            else { label_Copy162.Height += size; }

            if (direction[163] == 1) { label_Copy163.Width += size; }
            else { label_Copy163.Height += size; }

            if (direction[164] == 1) { label_Copy164.Width += size; }
            else { label_Copy164.Height += size; }

            if (direction[165] == 1) { label_Copy165.Width += size; }
            else { label_Copy165.Height += size; }

            if (direction[166] == 1) { label_Copy166.Width += size; }
            else { label_Copy166.Height += size; }

            if (direction[167] == 1) { label_Copy167.Width += size; }
            else { label_Copy167.Height += size; }

            if (direction[168] == 1) { label_Copy168.Width += size; }
            else { label_Copy168.Height += size; }

            if (direction[169] == 1) { label_Copy169.Width += size; }
            else { label_Copy169.Height += size; }

            if (direction[170] == 1) { label_Copy170.Width += size; }
            else { label_Copy170.Height += size; }

            if (direction[171] == 1) { label_Copy171.Width += size; }
            else { label_Copy171.Height += size; }

            if (direction[172] == 1) { label_Copy172.Width += size; }
            else { label_Copy172.Height += size; }

            if (direction[173] == 1) { label_Copy173.Width += size; }
            else { label_Copy173.Height += size; }

            if (direction[174] == 1) { label_Copy174.Width += size; }
            else { label_Copy174.Height += size; }

            if (direction[175] == 1) { label_Copy175.Width += size; }
            else { label_Copy175.Height += size; }

            if (direction[176] == 1) { label_Copy176.Width += size; }
            else { label_Copy176.Height += size; }

            if (direction[177] == 1) { label_Copy177.Width += size; }
            else { label_Copy177.Height += size; }

            if (direction[178] == 1) { label_Copy178.Width += size; }
            else { label_Copy178.Height += size; }

            if (direction[179] == 1) { label_Copy179.Width += size; }
            else { label_Copy179.Height += size; }

            if (direction[180] == 1) { label_Copy180.Width += size; }
            else { label_Copy180.Height += size; }

            if (direction[181] == 1) { label_Copy181.Width += size; }
            else { label_Copy181.Height += size; }

            if (direction[182] == 1) { label_Copy182.Width += size; }
            else { label_Copy182.Height += size; }

            if (direction[183] == 1) { label_Copy183.Width += size; }
            else { label_Copy183.Height += size; }

            if (direction[184] == 1) { label_Copy184.Width += size; }
            else { label_Copy184.Height += size; }

            if (direction[185] == 1) { label_Copy185.Width += size; }
            else { label_Copy185.Height += size; }

            if (direction[186] == 1) { label_Copy186.Width += size; }
            else { label_Copy186.Height += size; }

            if (direction[187] == 1) { label_Copy187.Width += size; }
            else { label_Copy187.Height += size; }

            if (direction[188] == 1) { label_Copy188.Width += size; }
            else { label_Copy188.Height += size; }

            if (direction[189] == 1) { label_Copy189.Width += size; }
            else { label_Copy189.Height += size; }

            if (direction[190] == 1) { label_Copy190.Width += size; }
            else { label_Copy190.Height += size; }

            if (direction[191] == 1) { label_Copy191.Width += size; }
            else { label_Copy191.Height += size; }

            if (direction[192] == 1) { label_Copy192.Width += size; }
            else { label_Copy192.Height += size; }

            if (direction[193] == 1) { label_Copy193.Width += size; }
            else { label_Copy193.Height += size; }

            if (direction[194] == 1) { label_Copy194.Width += size; }
            else { label_Copy194.Height += size; }

            if (direction[195] == 1) { label_Copy195.Width += size; }
            else { label_Copy195.Height += size; }

            if (direction[196] == 1) { label_Copy196.Width += size; }
            else { label_Copy196.Height += size; }

            if (direction[197] == 1) { label_Copy197.Width += size; }
            else { label_Copy197.Height += size; }

            if (direction[198] == 1) { label_Copy198.Width += size; }
            else { label_Copy198.Height += size; }

            if (direction[199] == 1) { label_Copy199.Width += size; }
            else { label_Copy199.Height += size; }

            if (direction[200] == 1) { label_Copy200.Width += size; }
            else { label_Copy200.Height += size; }

            if (direction[201] == 1) { label_Copy201.Width += size; }
            else { label_Copy201.Height += size; }

            if (direction[202] == 1) { label_Copy202.Width += size; }
            else { label_Copy202.Height += size; }

            if (direction[203] == 1) { label_Copy203.Width += size; }
            else { label_Copy203.Height += size; }

            if (direction[204] == 1) { label_Copy204.Width += size; }
            else { label_Copy204.Height += size; }

            if (direction[205] == 1) { label_Copy205.Width += size; }
            else { label_Copy205.Height += size; }

            if (direction[206] == 1) { label_Copy206.Width += size; }
            else { label_Copy206.Height += size; }

            if (direction[207] == 1) { label_Copy207.Width += size; }
            else { label_Copy207.Height += size; }

            if (direction[208] == 1) { label_Copy208.Width += size; }
            else { label_Copy208.Height += size; }

            if (direction[209] == 1) { label_Copy209.Width += size; }
            else { label_Copy209.Height += size; }

            if (direction[210] == 1) { label_Copy210.Width += size; }
            else { label_Copy210.Height += size; }

            if (direction[211] == 1) { label_Copy211.Width += size; }
            else { label_Copy211.Height += size; }

            if (direction[212] == 1) { label_Copy212.Width += size; }
            else { label_Copy212.Height += size; }

            if (direction[213] == 1) { label_Copy213.Width += size; }
            else { label_Copy213.Height += size; }

            if (direction[214] == 1) { label_Copy214.Width += size; }
            else { label_Copy214.Height += size; }

            if (direction[215] == 1) { label_Copy215.Width += size; }
            else { label_Copy215.Height += size; }

            if (direction[216] == 1) { label_Copy216.Width += size; }
            else { label_Copy216.Height += size; }

            if (direction[217] == 1) { label_Copy217.Width += size; }
            else { label_Copy217.Height += size; }

            if (direction[218] == 1) { label_Copy218.Width += size; }
            else { label_Copy218.Height += size; }

            if (direction[219] == 1) { label_Copy219.Width += size; }
            else { label_Copy219.Height += size; }

            if (direction[220] == 1) { label_Copy220.Width += size; }
            else { label_Copy220.Height += size; }

            if (direction[221] == 1) { label_Copy221.Width += size; }
            else { label_Copy221.Height += size; }

            if (direction[222] == 1) { label_Copy222.Width += size; }
            else { label_Copy222.Height += size; }

            if (direction[223] == 1) { label_Copy223.Width += size; }
            else { label_Copy223.Height += size; }

            if (direction[224] == 1) { label_Copy224.Width += size; }
            else { label_Copy224.Height += size; }

            if (direction[225] == 1) { label_Copy225.Width += size; }
            else { label_Copy225.Height += size; }

            if (direction[226] == 1) { label_Copy226.Width += size; }
            else { label_Copy226.Height += size; }

            if (direction[227] == 1) { label_Copy227.Width += size; }
            else { label_Copy227.Height += size; }

            if (direction[228] == 1) { label_Copy228.Width += size; }
            else { label_Copy228.Height += size; }

            if (direction[229] == 1) { label_Copy229.Width += size; }
            else { label_Copy229.Height += size; }

            if (direction[230] == 1) { label_Copy230.Width += size; }
            else { label_Copy230.Height += size; }

            if (direction[231] == 1) { label_Copy231.Width += size; }
            else { label_Copy231.Height += size; }

            if (direction[232] == 1) { label_Copy232.Width += size; }
            else { label_Copy232.Height += size; }

            if (direction[233] == 1) { label_Copy233.Width += size; }
            else { label_Copy233.Height += size; }

            if (direction[234] == 1) { label_Copy234.Width += size; }
            else { label_Copy234.Height += size; }

            if (direction[235] == 1) { label_Copy235.Width += size; }
            else { label_Copy235.Height += size; }

            if (direction[236] == 1) { label_Copy236.Width += size; }
            else { label_Copy236.Height += size; }

            if (direction[237] == 1) { label_Copy237.Width += size; }
            else { label_Copy237.Height += size; }

            if (direction[238] == 1) { label_Copy238.Width += size; }
            else { label_Copy238.Height += size; }

            if (direction[239] == 1) { label_Copy239.Width += size; }
            else { label_Copy239.Height += size; }

            if (direction[240] == 1) { label_Copy240.Width += size; }
            else { label_Copy240.Height += size; }

            if (direction[241] == 1) { label_Copy241.Width += size; }
            else { label_Copy241.Height += size; }

            if (direction[242] == 1) { label_Copy242.Width += size; }
            else { label_Copy242.Height += size; }

            if (direction[243] == 1) { label_Copy243.Width += size; }
            else { label_Copy243.Height += size; }

            if (direction[244] == 1) { label_Copy244.Width += size; }
            else { label_Copy244.Height += size; }

            if (direction[245] == 1) { label_Copy245.Width += size; }
            else { label_Copy245.Height += size; }

            if (direction[246] == 1) { label_Copy246.Width += size; }
            else { label_Copy246.Height += size; }

            if (direction[247] == 1) { label_Copy247.Width += size; }
            else { label_Copy247.Height += size; }

            if (direction[248] == 1) { label_Copy248.Width += size; }
            else { label_Copy248.Height += size; }

            if (direction[249] == 1) { label_Copy249.Width += size; }
            else { label_Copy249.Height += size; }

            if (direction[250] == 1) { label_Copy250.Width += size; }
            else { label_Copy250.Height += size; }

            if (direction[251] == 1) { label_Copy251.Width += size; }
            else { label_Copy251.Height += size; }

            if (direction[252] == 1) { label_Copy252.Width += size; }
            else { label_Copy252.Height += size; }

            if (direction[253] == 1) { label_Copy253.Width += size; }
            else { label_Copy253.Height += size; }

            if (direction[254] == 1) { label_Copy254.Width += size; }
            else { label_Copy254.Height += size; }

            if (direction[255] == 1) { label_Copy255.Width += size; }
            else { label_Copy255.Height += size; }

            if (direction[256] == 1) { label_Copy256.Width += size; }
            else { label_Copy256.Height += size; }

            if (direction[257] == 1) { label_Copy257.Width += size; }
            else { label_Copy257.Height += size; }

            if (direction[258] == 1) { label_Copy258.Width += size; }
            else { label_Copy258.Height += size; }

            if (direction[259] == 1) { label_Copy259.Width += size; }
            else { label_Copy259.Height += size; }

            if (direction[260] == 1) { label_Copy260.Width += size; }
            else { label_Copy260.Height += size; }

            if (direction[261] == 1) { label_Copy261.Width += size; }
            else { label_Copy261.Height += size; }

            if (direction[262] == 1) { label_Copy262.Width += size; }
            else { label_Copy262.Height += size; }

            if (direction[263] == 1) { label_Copy263.Width += size; }
            else { label_Copy263.Height += size; }

            if (direction[264] == 1) { label_Copy264.Width += size; }
            else { label_Copy264.Height += size; }

            if (direction[265] == 1) { label_Copy265.Width += size; }
            else { label_Copy265.Height += size; }

            if (direction[266] == 1) { label_Copy266.Width += size; }
            else { label_Copy266.Height += size; }

            if (direction[267] == 1) { label_Copy267.Width += size; }
            else { label_Copy267.Height += size; }

            if (direction[268] == 1) { label_Copy268.Width += size; }
            else { label_Copy268.Height += size; }

            if (direction[269] == 1) { label_Copy269.Width += size; }
            else { label_Copy269.Height += size; }

            if (direction[270] == 1) { label_Copy270.Width += size; }
            else { label_Copy260.Height += size; }

            if (direction[271] == 1) { label_Copy271.Width += size; }
            else { label_Copy271.Height += size; }

            if (direction[272] == 1) { label_Copy272.Width += size; }
            else { label_Copy272.Height += size; }

            if (direction[273] == 1) { label_Copy273.Width += size; }
            else { label_Copy273.Height += size; }

            if (direction[274] == 1) { label_Copy274.Width += size; }
            else { label_Copy274.Height += size; }

            if (direction[275] == 1) { label_Copy275.Width += size; }
            else { label_Copy275.Height += size; }

            if (direction[276] == 1) { label_Copy276.Width += size; }
            else { label_Copy276.Height += size; }

            if (direction[277] == 1) { label_Copy277.Width += size; }
            else { label_Copy277.Height += size; }

            if (direction[278] == 1) { label_Copy278.Width += size; }
            else { label_Copy278.Height += size; }

            if (direction[279] == 1) { label_Copy279.Width += size; }
            else { label_Copy279.Height += size; }

            if (direction[280] == 1) { label_Copy280.Width += size; }
            else { label_Copy280.Height += size; }

            if (direction[281] == 1) { label_Copy281.Width += size; }
            else { label_Copy281.Height += size; }

            if (direction[282] == 1) { label_Copy282.Width += size; }
            else { label_Copy282.Height += size; }

            if (direction[283] == 1) { label_Copy283.Width += size; }
            else { label_Copy283.Height += size; }

            if (direction[284] == 1) { label_Copy284.Width += size; }
            else { label_Copy284.Height += size; }

            if (direction[285] == 1) { label_Copy285.Width += size; }
            else { label_Copy285.Height += size; }

            if (direction[286] == 1) { label_Copy286.Width += size; }
            else { label_Copy286.Height += size; }

            if (direction[287] == 1) { label_Copy287.Width += size; }
            else { label_Copy287.Height += size; }

            if (direction[288] == 1) { label_Copy288.Width += size; }
            else { label_Copy288.Height += size; }

            if (direction[289] == 1) { label_Copy289.Width += size; }
            else { label_Copy289.Height += size; }

            if (direction[290] == 1) { label_Copy290.Width += size; }
            else { label_Copy290.Height += size; }

            if (direction[291] == 1) { label_Copy291.Width += size; }
            else { label_Copy291.Height += size; }

            if (direction[292] == 1) { label_Copy292.Width += size; }
            else { label_Copy292.Height += size; }

            if (direction[293] == 1) { label_Copy293.Width += size; }
            else { label_Copy293.Height += size; }

            if (direction[294] == 1) { label_Copy294.Width += size; }
            else { label_Copy294.Height += size; }

            if (direction[295] == 1) { label_Copy295.Width += size; }
            else { label_Copy295.Height += size; }

            if (direction[296] == 1) { label_Copy296.Width += size; }
            else { label_Copy296.Height += size; }

            if (direction[297] == 1) { label_Copy297.Width += size; }
            else { label_Copy297.Height += size; }

            if (direction[298] == 1) { label_Copy298.Width += size; }
            else { label_Copy298.Height += size; }

            if (direction[299] == 1) { label_Copy299.Width += size; }
            else { label_Copy299.Height += size; }

            if (direction[300] == 1) { label_Copy300.Width += size; }
            else { label_Copy300.Height += size; }

            if (direction[301] == 1) { label_Copy301.Width += size; }
            else { label_Copy301.Height += size; }

            if (direction[302] == 1) { label_Copy302.Width += size; }
            else { label_Copy302.Height += size; }

            if (direction[303] == 1) { label_Copy303.Width += size; }
            else { label_Copy303.Height += size; }

            if (direction[304] == 1) { label_Copy304.Width += size; }
            else { label_Copy304.Height += size; }

            if (direction[305] == 1) { label_Copy305.Width += size; }
            else { label_Copy305.Height += size; }

            if (direction[306] == 1) { label_Copy306.Width += size; }
            else { label_Copy306.Height += size; }

            if (direction[307] == 1) { label_Copy307.Width += size; }
            else { label_Copy307.Height += size; }

            if (direction[308] == 1) { label_Copy308.Width += size; }
            else { label_Copy308.Height += size; }

            if (direction[309] == 1) { label_Copy309.Width += size; }
            else { label_Copy309.Height += size; }

            if (direction[310] == 1) { label_Copy310.Width += size; }
            else { label_Copy310.Height += size; }

            if (direction[311] == 1) { label_Copy311.Width += size; }
            else { label_Copy311.Height += size; }

            if (direction[312] == 1) { label_Copy312.Width += size; }
            else { label_Copy312.Height += size; }

            if (direction[313] == 1) { label_Copy313.Width += size; }
            else { label_Copy313.Height += size; }

            if (direction[314] == 1) { label_Copy314.Width += size; }
            else { label_Copy314.Height += size; }

            if (direction[315] == 1) { label_Copy315.Width += size; }
            else { label_Copy315.Height += size; }

            if (direction[316] == 1) { label_Copy316.Width += size; }
            else { label_Copy316.Height += size; }

            if (direction[317] == 1) { label_Copy317.Width += size; }
            else { label_Copy317.Height += size; }

            if (direction[318] == 1) { label_Copy318.Width += size; }
            else { label_Copy318.Height += size; }

            if (direction[319] == 1) { label_Copy319.Width += size; }
            else { label_Copy319.Height += size; }

            if (direction[320] == 1) { label_Copy320.Width += size; }
            else { label_Copy320.Height += size; }

            if (direction[321] == 1) { label_Copy321.Width += size; }
            else { label_Copy321.Height += size; }

            if (direction[322] == 1) { label_Copy322.Width += size; }
            else { label_Copy322.Height += size; }

            if (direction[323] == 1) { label_Copy323.Width += size; }
            else { label_Copy323.Height += size; }

            if (direction[324] == 1) { label_Copy324.Width += size; }
            else { label_Copy324.Height += size; }

            if (direction[325] == 1) { label_Copy325.Width += size; }
            else { label_Copy325.Height += size; }

            if (direction[326] == 1) { label_Copy326.Width += size; }
            else { label_Copy326.Height += size; }

            if (direction[327] == 1) { label_Copy327.Width += size; }
            else { label_Copy327.Height += size; }

            if (direction[328] == 1) { label_Copy328.Width += size; }
            else { label_Copy328.Height += size; }

            if (direction[329] == 1) { label_Copy329.Width += size; }
            else { label_Copy329.Height += size; }

            if (direction[330] == 1) { label_Copy330.Width += size; }
            else { label_Copy330.Height += size; }

            if (direction[331] == 1) { label_Copy331.Width += size; }
            else { label_Copy331.Height += size; }

            if (direction[332] == 1) { label_Copy332.Width += size; }
            else { label_Copy332.Height += size; }

            if (direction[333] == 1) { label_Copy333.Width += size; }
            else { label_Copy333.Height += size; }

            if (direction[334] == 1) { label_Copy334.Width += size; }
            else { label_Copy334.Height += size; }

            if (direction[335] == 1) { label_Copy335.Width += size; }
            else { label_Copy335.Height += size; }

            if (direction[336] == 1) { label_Copy336.Width += size; }
            else { label_Copy336.Height += size; }

            if (direction[337] == 1) { label_Copy337.Width += size; }
            else { label_Copy337.Height += size; }

            if (direction[338] == 1) { label_Copy338.Width += size; }
            else { label_Copy338.Height += size; }

            if (direction[339] == 1) { label_Copy339.Width += size; }
            else { label_Copy339.Height += size; }

            if (direction[340] == 1) { label_Copy340.Width += size; }
            else { label_Copy340.Height += size; }

            if (direction[341] == 1) { label_Copy341.Width += size; }
            else { label_Copy341.Height += size; }

            if (direction[342] == 1) { label_Copy342.Width += size; }
            else { label_Copy342.Height += size; }

            if (direction[343] == 1) { label_Copy343.Width += size; }
            else { label_Copy343.Height += size; }

            if (direction[344] == 1) { label_Copy344.Width += size; }
            else { label_Copy344.Height += size; }

            if (direction[345] == 1) { label_Copy345.Width += size; }
            else { label_Copy345.Height += size; }

            if (direction[346] == 1) { label_Copy346.Width += size; }
            else { label_Copy346.Height += size; }

            if (direction[347] == 1) { label_Copy347.Width += size; }
            else { label_Copy347.Height += size; }

            if (direction[348] == 1) { label_Copy348.Width += size; }
            else { label_Copy348.Height += size; }

            if (direction[349] == 1) { label_Copy349.Width += size; }
            else { label_Copy349.Height += size; }

            if (direction[350] == 1) { label_Copy350.Width += size; }
            else { label_Copy350.Height += size; }

            if (direction[351] == 1) { label_Copy351.Width += size; }
            else { label_Copy351.Height += size; }

            if (direction[352] == 1) { label_Copy352.Width += size; }
            else { label_Copy352.Height += size; }

            if (direction[353] == 1) { label_Copy353.Width += size; }
            else { label_Copy353.Height += size; }

            if (direction[354] == 1) { label_Copy354.Width += size; }
            else { label_Copy354.Height += size; }

            if (direction[355] == 1) { label_Copy355.Width += size; }
            else { label_Copy355.Height += size; }

            if (direction[356] == 1) { label_Copy356.Width += size; }
            else { label_Copy356.Height += size; }

            if (direction[357] == 1) { label_Copy357.Width += size; }
            else { label_Copy357.Height += size; }

            if (direction[358] == 1) { label_Copy358.Width += size; }
            else { label_Copy358.Height += size; }

            if (direction[359] == 1) { label_Copy359.Width += size; }
            else { label_Copy359.Height += size; }

            if (direction[360] == 1) { label_Copy360.Width += size; }
            else { label_Copy360.Height += size; }

            if (direction[361] == 1) { label_Copy361.Width += size; }
            else { label_Copy361.Height += size; }

            if (direction[362] == 1) { label_Copy362.Width += size; }
            else { label_Copy362.Height += size; }

            if (direction[363] == 1) { label_Copy363.Width += size; }
            else { label_Copy363.Height += size; }

            if (direction[364] == 1) { label_Copy364.Width += size; }
            else { label_Copy364.Height += size; }

            if (direction[365] == 1) { label_Copy365.Width += size; }
            else { label_Copy365.Height += size; }

            if (direction[366] == 1) { label_Copy366.Width += size; }
            else { label_Copy366.Height += size; }

            if (direction[367] == 1) { label_Copy367.Width += size; }
            else { label_Copy367.Height += size; }

            if (direction[368] == 1) { label_Copy368.Width += size; }
            else { label_Copy368.Height += size; }

            if (direction[369] == 1) { label_Copy369.Width += size; }
            else { label_Copy369.Height += size; }

            if (direction[370] == 1) { label_Copy370.Width += size; }
            else { label_Copy370.Height += size; }

            if (direction[371] == 1) { label_Copy371.Width += size; }
            else { label_Copy371.Height += size; }

            if (direction[372] == 1) { label_Copy372.Width += size; }
            else { label_Copy372.Height += size; }

            if (direction[373] == 1) { label_Copy373.Width += size; }
            else { label_Copy373.Height += size; }

            if (direction[374] == 1) { label_Copy374.Width += size; }
            else { label_Copy374.Height += size; }

            if (direction[375] == 1) { label_Copy375.Width += size; }
            else { label_Copy375.Height += size; }

            if (direction[376] == 1) { label_Copy376.Width += size; }
            else { label_Copy376.Height += size; }

            if (direction[377] == 1) { label_Copy377.Width += size; }
            else { label_Copy377.Height += size; }

            if (direction[378] == 1) { label_Copy378.Width += size; }
            else { label_Copy378.Height += size; }

            if (direction[379] == 1) { label_Copy379.Width += size; }
            else { label_Copy379.Height += size; }

            if (direction[380] == 1) { label_Copy380.Width += size; }
            else { label_Copy380.Height += size; }

            if (direction[381] == 1) { label_Copy381.Width += size; }
            else { label_Copy381.Height += size; }

            if (direction[382] == 1) { label_Copy382.Width += size; }
            else { label_Copy382.Height += size; }

            if (direction[383] == 1) { label_Copy383.Width += size; }
            else { label_Copy383.Height += size; }

            if (direction[384] == 1) { label_Copy384.Width += size; }
            else { label_Copy384.Height += size; }

            if (direction[385] == 1) { label_Copy385.Width += size; }
            else { label_Copy385.Height += size; }

            if (direction[386] == 1) { label_Copy386.Width += size; }
            else { label_Copy386.Height += size; }

            if (direction[387] == 1) { label_Copy387.Width += size; }
            else { label_Copy387.Height += size; }

            if (direction[388] == 1) { label_Copy388.Width += size; }
            else { label_Copy388.Height += size; }

            if (direction[389] == 1) { label_Copy389.Width += size; }
            else { label_Copy389.Height += size; }

            if (direction[390] == 1) { label_Copy390.Width += size; }
            else { label_Copy390.Height += size; }

            if (direction[391] == 1) { label_Copy391.Width += size; }
            else { label_Copy391.Height += size; }

            if (direction[392] == 1) { label_Copy392.Width += size; }
            else { label_Copy392.Height += size; }

            if (direction[393] == 1) { label_Copy393.Width += size; }
            else { label_Copy393.Height += size; }

            if (direction[394] == 1) { label_Copy394.Width += size; }
            else { label_Copy394.Height += size; }

            if (direction[395] == 1) { label_Copy395.Width += size; }
            else { label_Copy395.Height += size; }

            if (direction[396] == 1) { label_Copy396.Width += size; }
            else { label_Copy396.Height += size; }

            if (direction[397] == 1) { label_Copy397.Width += size; }
            else { label_Copy397.Height += size; }

            if (direction[398] == 1) { label_Copy398.Width += size; }
            else { label_Copy398.Height += size; }

            if (direction[399] == 1) { label_Copy399.Width += size; }
            else { label_Copy399.Height += size; }

            if (direction[400] == 1) { label_Copy400.Width += size; }
            else { label_Copy400.Height += size; }

            if (direction[401] == 1) { label_Copy401.Width += size; }
            else { label_Copy401.Height += size; }

            if (direction[402] == 1) { label_Copy402.Width += size; }
            else { label_Copy402.Height += size; }

            if (direction[403] == 1) { label_Copy403.Width += size; }
            else { label_Copy403.Height += size; }

            if (direction[404] == 1) { label_Copy404.Width += size; }
            else { label_Copy404.Height += size; }

            if (direction[405] == 1) { label_Copy405.Width += size; }
            else { label_Copy405.Height += size; }

            if (direction[406] == 1) { label_Copy406.Width += size; }
            else { label_Copy406.Height += size; }

            if (direction[407] == 1) { label_Copy407.Width += size; }
            else { label_Copy407.Height += size; }

            if (direction[408] == 1) { label_Copy408.Width += size; }
            else { label_Copy408.Height += size; }

            if (direction[409] == 1) { label_Copy409.Width += size; }
            else { label_Copy409.Height += size; }

            if (direction[410] == 1) { label_Copy410.Width += size; }
            else { label_Copy410.Height += size; }

            if (direction[411] == 1) { label_Copy411.Width += size; }
            else { label_Copy411.Height += size; }

            if (direction[412] == 1) { label_Copy412.Width += size; }
            else { label_Copy412.Height += size; }

            if (direction[413] == 1) { label_Copy413.Width += size; }
            else { label_Copy413.Height += size; }

            if (direction[414] == 1) { label_Copy414.Width += size; }
            else { label_Copy414.Height += size; }

            if (direction[415] == 1) { label_Copy415.Width += size; }
            else { label_Copy415.Height += size; }

            if (direction[416] == 1) { label_Copy416.Width += size; }
            else { label_Copy416.Height += size; }

            if (direction[417] == 1) { label_Copy417.Width += size; }
            else { label_Copy417.Height += size; }

            if (direction[418] == 1) { label_Copy418.Width += size; }
            else { label_Copy418.Height += size; }

            if (direction[419] == 1) { label_Copy419.Width += size; }
            else { label_Copy419.Height += size; }

            if (direction[420] == 1) { label_Copy420.Width += size; }
            else { label_Copy420.Height += size; }

            if (direction[421] == 1) { label_Copy421.Width += size; }
            else { label_Copy421.Height += size; }

            if (direction[422] == 1) { label_Copy422.Width += size; }
            else { label_Copy422.Height += size; }

            if (direction[423] == 1) { label_Copy423.Width += size; }
            else { label_Copy423.Height += size; }

            if (direction[424] == 1) { label_Copy424.Width += size; }
            else { label_Copy424.Height += size; }

            if (direction[425] == 1) { label_Copy425.Width += size; }
            else { label_Copy425.Height += size; }

            if (direction[426] == 1) { label_Copy426.Width += size; }
            else { label_Copy426.Height += size; }

            if (direction[427] == 1) { label_Copy427.Width += size; }
            else { label_Copy427.Height += size; }

            if (direction[428] == 1) { label_Copy428.Width += size; }
            else { label_Copy428.Height += size; }

            if (direction[429] == 1) { label_Copy429.Width += size; }
            else { label_Copy429.Height += size; }

            if (direction[430] == 1) { label_Copy430.Width += size; }
            else { label_Copy430.Height += size; }

            if (direction[431] == 1) { label_Copy431.Width += size; }
            else { label_Copy431.Height += size; }

            if (direction[432] == 1) { label_Copy432.Width += size; }
            else { label_Copy432.Height += size; }

            if (direction[433] == 1) { label_Copy433.Width += size; }
            else { label_Copy433.Height += size; }

            if (direction[434] == 1) { label_Copy434.Width += size; }
            else { label_Copy434.Height += size; }

            if (direction[435] == 1) { label_Copy435.Width += size; }
            else { label_Copy435.Height += size; }

            if (direction[436] == 1) { label_Copy436.Width += size; }
            else { label_Copy436.Height += size; }

            if (direction[437] == 1) { label_Copy437.Width += size; }
            else { label_Copy437.Height += size; }

            if (direction[438] == 1) { label_Copy438.Width += size; }
            else { label_Copy438.Height += size; }

            if (direction[439] == 1) { label_Copy439.Width += size; }
            else { label_Copy439.Height += size; }

            if (direction[440] == 1) { label_Copy440.Width += size; }
            else { label_Copy440.Height += size; }

            if (direction[441] == 1) { label_Copy441.Width += size; }
            else { label_Copy441.Height += size; }

            if (direction[442] == 1) { label_Copy442.Width += size; }
            else { label_Copy442.Height += size; }

            if (direction[443] == 1) { label_Copy443.Width += size; }
            else { label_Copy443.Height += size; }

            if (direction[444] == 1) { label_Copy444.Width += size; }
            else { label_Copy444.Height += size; }

            if (direction[445] == 1) { label_Copy445.Width += size; }
            else { label_Copy445.Height += size; }

            if (direction[446] == 1) { label_Copy446.Width += size; }
            else { label_Copy446.Height += size; }

            if (direction[447] == 1) { label_Copy447.Width += size; }
            else { label_Copy447.Height += size; }

            if (direction[448] == 1) { label_Copy448.Width += size; }
            else { label_Copy448.Height += size; }

            if (direction[449] == 1) { label_Copy449.Width += size; }
            else { label_Copy449.Height += size; }

            if (direction[450] == 1) { label_Copy450.Width += size; }
            else { label_Copy450.Height += size; }

            if (direction[451] == 1) { label_Copy451.Width += size; }
            else { label_Copy451.Height += size; }

            if (direction[452] == 1) { label_Copy452.Width += size; }
            else { label_Copy452.Height += size; }

            if (direction[453] == 1) { label_Copy453.Width += size; }
            else { label_Copy453.Height += size; }

            if (direction[454] == 1) { label_Copy454.Width += size; }
            else { label_Copy454.Height += size; }

            if (direction[455] == 1) { label_Copy455.Width += size; }
            else { label_Copy455.Height += size; }

            if (direction[456] == 1) { label_Copy456.Width += size; }
            else { label_Copy456.Height += size; }

            if (direction[457] == 1) { label_Copy457.Width += size; }
            else { label_Copy457.Height += size; }

            if (direction[458] == 1) { label_Copy458.Width += size; }
            else { label_Copy458.Height += size; }

            if (direction[459] == 1) { label_Copy459.Width += size; }
            else { label_Copy459.Height += size; }

            if (direction[460] == 1) { label_Copy460.Width += size; }
            else { label_Copy460.Height += size; }

            if (direction[461] == 1) { label_Copy461.Width += size; }
            else { label_Copy461.Height += size; }

            if (direction[462] == 1) { label_Copy462.Width += size; }
            else { label_Copy462.Height += size; }

            if (direction[463] == 1) { label_Copy463.Width += size; }
            else { label_Copy463.Height += size; }

            if (direction[464] == 1) { label_Copy464.Width += size; }
            else { label_Copy464.Height += size; }

            if (direction[465] == 1) { label_Copy465.Width += size; }
            else { label_Copy465.Height += size; }

            if (direction[466] == 1) { label_Copy466.Width += size; }
            else { label_Copy466.Height += size; }

            if (direction[467] == 1) { label_Copy467.Width += size; }
            else { label_Copy467.Height += size; }

            if (direction[468] == 1) { label_Copy468.Width += size; }
            else { label_Copy468.Height += size; }

            if (direction[469] == 1) { label_Copy469.Width += size; }
            else { label_Copy469.Height += size; }

            if (direction[470] == 1) { label_Copy470.Width += size; }
            else { label_Copy470.Height += size; }

            if (direction[471] == 1) { label_Copy471.Width += size; }
            else { label_Copy471.Height += size; }

            if (direction[472] == 1) { label_Copy472.Width += size; }
            else { label_Copy472.Height += size; }

            if (direction[473] == 1) { label_Copy473.Width += size; }
            else { label_Copy473.Height += size; }

            if (direction[474] == 1) { label_Copy474.Width += size; }
            else { label_Copy474.Height += size; }

            if (direction[475] == 1) { label_Copy475.Width += size; }
            else { label_Copy475.Height += size; }

            if (direction[476] == 1) { label_Copy476.Width += size; }
            else { label_Copy476.Height += size; }

            if (direction[477] == 1) { label_Copy477.Width += size; }
            else { label_Copy477.Height += size; }

            if (direction[478] == 1) { label_Copy478.Width += size; }
            else { label_Copy478.Height += size; }

            if (direction[479] == 1) { label_Copy479.Width += size; }
            else { label_Copy479.Height += size; }

            if (direction[480] == 1) { label_Copy480.Width += size; }
            else { label_Copy480.Height += size; }

            if (direction[481] == 1) { label_Copy481.Width += size; }
            else { label_Copy481.Height += size; }

            if (direction[482] == 1) { label_Copy482.Width += size; }
            else { label_Copy482.Height += size; }

        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            Double leftPosition = Canvas.GetLeft(this.MoveLabel); //左を取得　動かすオブジェクト
            Double topPosition = Canvas.GetTop(this.MoveLabel); //上部を取得
            Double rightPosition = Canvas.GetRight(this.MoveLabel);
            Double bottomPosition = Canvas.GetBottom(this.MoveLabel);

            Double posX_label = Canvas.GetLeft(this.label_Copy);
            Double posY_label = Canvas.GetTop(this.label_Copy);
            Double posX2_label = Canvas.GetRight(this.label_Copy);
            Double posY2_label = Canvas.GetBottom(this.label_Copy);


            textBlock.Text = "X=" + leftPosition.ToString() + "  " + "Y=" + topPosition.ToString();

            Key key = e.Key;
            if (e.Key == Key.Up) //上キーを押したとき
            {
                Canvas.SetTop(this.MoveLabel, topPosition - 10);
                if (true)
                {
                    //Canvas.SetTop(this.MoveLabel, topPosition + 10);
                    Rectangle rect = new Rectangle();
                    rect.Fill = Brushes.Yellow;
                    rect.Width = 10;
                    rect.Height = 10;
                    rect.Margin = new Thickness(leftPosition, topPosition, leftPosition + 10, topPosition + 10);
                    rect.Stroke = Brushes.Yellow;

                    //  canvas.Children.Add(rect);

                    Rect position1 = new Rect(); //Labelの座標を取得
                    position1.Location = label_Copy.PointToScreen(new Point(0, 0));
                    position1.Height = label_Copy.ActualHeight;
                    position1.Width = label_Copy.ActualWidth;

                    Rect moveposition = new Rect();
                    moveposition.Location = MoveLabel.PointToScreen(new Point(0, 0));
                    moveposition.Height = MoveLabel.ActualHeight;
                    moveposition.Width = MoveLabel.ActualWidth + 0.1;




                    if (position1.IntersectsWith(moveposition))
                    {
                        textBlock.Text = "重なっとる";
                    }
                }


            }
            else if (e.Key == Key.Down) //下キーを押したとき
            {
                Canvas.SetTop(this.MoveLabel, topPosition + 10);

                Rectangle rect = new Rectangle();
                rect.Fill = Brushes.Yellow;
                rect.Width = 10;
                rect.Height = 10;
                rect.Margin = new Thickness(leftPosition, topPosition, leftPosition + 10, topPosition + 10);
                rect.Stroke = Brushes.Yellow;


                Rect position1 = new Rect(); //Labelの座標を取得
                position1.Location = label_Copy.PointToScreen(new Point(0, 0));
                position1.Height = label_Copy.ActualHeight;
                position1.Width = label_Copy.ActualWidth;

                Rect moveposition = new Rect();
                moveposition.Location = MoveLabel.PointToScreen(new Point(0, 0));
                moveposition.Height = MoveLabel.ActualHeight - 0.1;
                moveposition.Width = MoveLabel.ActualWidth;



                //canvas.Children.Add(rect);
                if (position1.IntersectsWith(moveposition))
                {
                    textBlock.Text = "重なっとる";
                }
            }
            else if (e.Key == Key.Left) //左キーを押したとき
            {
                Canvas.SetLeft(this.MoveLabel, leftPosition - 10);

                Rectangle rect = new Rectangle();
                rect.Fill = Brushes.Yellow;
                rect.Width = 10;
                rect.Height = 10;
                rect.Margin = new Thickness(leftPosition, topPosition, leftPosition + 10, topPosition + 10);
                rect.Stroke = Brushes.Yellow;

                //canvas.Children.Add(rect);

                Rect position1 = new Rect(); //Labelの座標を取得
                position1.Location = label_Copy.PointToScreen(new Point(0, 0));
                position1.Height = label_Copy.ActualHeight;
                position1.Width = label_Copy.ActualWidth;

                Rect moveposition = new Rect();
                moveposition.Location = MoveLabel.PointToScreen(new Point(0, 0));
                moveposition.Height = MoveLabel.ActualHeight;
                moveposition.Width = MoveLabel.ActualWidth - 0.1;

                if (position1.IntersectsWith(moveposition))
                {
                    textBlock.Text = "重なっとる";
                }
                moveposition.Width = MoveLabel.ActualWidth + 0.1;
            }
            else if (e.Key == Key.Right) //右キーを押したとき
            {
                Canvas.SetLeft(this.MoveLabel, leftPosition + 10);

                Rectangle rect = new Rectangle();
                rect.Fill = Brushes.Yellow;
                rect.Width = 10;
                rect.Height = 10;
                rect.Margin = new Thickness(leftPosition, topPosition, leftPosition + 10, topPosition + 10);
                rect.Stroke = Brushes.Yellow;

                //canvas.Children.Add(rect);


                Rect position1 = new Rect(); //Labelの座標を取得
                position1.Location = label_Copy.PointToScreen(new Point(0, 0));
                position1.Height = label_Copy.ActualHeight;
                position1.Width = label_Copy.ActualWidth;

                Rect moveposition = new Rect();
                moveposition.Location = MoveLabel.PointToScreen(new Point(0, 0));
                moveposition.Height = MoveLabel.ActualHeight + 0.1;
                moveposition.Width = MoveLabel.ActualWidth;


                if (position1.IntersectsWith(moveposition))
                {
                    textBlock.Text = "重なっとる";
                }
            }
        }
    }

}
