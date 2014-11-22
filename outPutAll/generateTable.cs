using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outPutAll
{
    public static  class generateTable
    {
        private static int a = 0;//行号
        private static int b = 0;//列号
        private static double x = 0;//循环次数
        //构造数据
        //用到边界点
        private static string buildString = "RowID," + "CulmsID," + "XRange," + "YRange," + "PointX," + "PointY\r\n";
        /// <summary>
        /// 返回总表
        /// </summary>
        /// <param name="path"></param>
        public static void OutAllFilds(string path)
        {
            for (int j = 15; j <= 55; j++)
            {
                a++;
                for (int i = 70; i <= 137; i++)    
                {
                    b++;
                    buildString += a.ToString() + "," + b.ToString() + "," + j.ToString() + "-" + (j + 1).ToString() + "," + i.ToString() + "-" + (i + 1).ToString() + "," +i.ToString()+","+ j.ToString()+ "\r\n";
                }
                //a = 0;
                b = 0;
            }
            //输出数据
            System.IO.File.WriteAllText(path, buildString);

        }

        /// <summary>
        /// 得到第二级格子的中心点
        /// </summary>
        public static void outCenterPointofBigTable()
        {   string centerString = "RowID," + "CulmsID," + "XRange," + "YRange," + "CenterPointX," + "CenterPointY\r\n";
            //float x = 15.5f;
            //float y = 70.5f;
            for (float i = 15.5f; i <=54.5f;i++ )
            {
                a++;
                for (float j = 70.5f; j <= 136.5f; j++)
                {
                    b++;
                    centerString += a.ToString() + "," + b.ToString() + "," + (i - 0.5f).ToString() + "-" + (i + 0.5f).ToString() + "," + (j - 0.5f).ToString() + "-" + (j + 0.5f).ToString() + "," + j.ToString() + "," + i.ToString()+"\r\n";
                }
                b = 0;

            }
            System.IO.File.WriteAllText(@"G:\RZPU\20141118fishnet\总表中心点.csv",centerString);
        }
        /// <summary>
        /// ----------------------------------------TEST-----------输出100*100  15--16     70-------71
        /// </summary>
        /// <disanji
        /// param name="rows">行号</param>
        /// <param name="culumss">列号</param>
        public static void OutFramTable(int rows, int culumss)
        {
            //int fileNum = rows * culumss * 100 * 100;//要生成的文件数
            //构造数据
            //buildString += "RowID," + "CulmsID," + "XRange," + "YRange," + "CenterPointX," + "CenterPointY\r\n";
            
            int countRow = 0;
            int countCulum = 0;
            float j = 0;
            float i=0;
            for(j= 70f;j<=71f;j+=0.01f)
            {
                countRow++;
                for( i=15f ;i<=16f;i+=0.01f)
                {
                    countCulum++;
                    buildString += countRow.ToString("0.00") + "," + countCulum.ToString("0.00") + "," + (j - 0.01f).ToString("0.00") + "-" + (j + 0.01f).ToString("0.00") + "," + (i - 0.01f).ToString("0.00") + "-" + (i + 0.01f).ToString("0.00") + "," + j.ToString("0.00") + "," + i.ToString("0.00") + "\r\n";
                }
                countCulum = 0;
                
                i = 0;
            }
            System.IO.File.WriteAllText(@"G:\RZPU\20141118fishnet\小格子\Chart" + i.ToString() + "-" + j.ToString() + ".csv", buildString);
            
            //for (int row = 1; row <= rows; row++)
            //{
            //    countRow++;
            //    for (int culum = 1; culum <= culumss; culum++)
            //    {
            //        countCulum++;
            //        #region 小方块遍历
            //        for (int forin = 0; forin < 100; forin++)//行
            //        {
            //            a++;
            //            float toj = j;
            //            for (int forout = 0; forout < 100; forout++) //列
            //            {
            //                b++;
            //                buildString += a.ToString() + "," + b.ToString() + "," + toj.ToString("0.00") + "-" + (toj += 0.01f).ToString("0.00") + "," + i.ToString("0.00") + "-" + (i + 0.01).ToString("0.00") + "," + (toj - 0.005).ToString("0.000") + "," + (i + 0.005).ToString("0.000") + "\r\n";

            //            }
            //            j = 14f + countCulum - 1;
            //            i = 69f + 0.01f * a;
            //            b = 0;
            //        }
            //        #endregion
            //        System.IO.File.WriteAllText(@"G:\RZPU\First\detalChart\Chart" + row.ToString() + "-" + culum.ToString() + ".csv", buildString);
            //        j += 1;
            //        buildString = "";
            //    }
            //    i = 69.00f + countRow;
            //    countCulum = 0;
            //    //i += 1;
            //    a = 0;
            //    j = 14f;

            //}
        }
        /// <summary>
        /// 第三级网格
        /// </summary>
        public static void getSmallFramPoint()
        {
            string framString ="Row,"+"Colum,"+ "framX," + "framY\r\n";
            float i = 15f;
            float j =70f ;
            float a=0;
            float b=0;
            int row = 0;
            int colum = 0;
            int lan = 0;
            int lon = 0;
            for ( i = 15f; i <= 55f; i++)
            {
                lan =Convert.ToInt32(i);
                for (j =70f; j <= 137f; j++)
                {
                    lon = Convert.ToInt32(j) ;
                    for (a = i; a <= i + 1.005f; a += 0.01f)         //0.005用来控制浮点型的误差
                    {
                        row++;
                        for(b=j;b<=j+1.005;b+=0.01f)
                        {
                            colum++;
                            framString += row.ToString() + "," + colum.ToString() + "," + b.ToString("0.00") + "," + a.ToString("0.00") + "\r\n";
                     }
                     colum = 0;
                    }
                    row = 0;
                    //输出
                    System.IO.File.WriteAllText(@"G:\RZPU\20141118fishnet\test\" + lan.ToString() + "-" + lon.ToString() + ".csv", framString);
                    framString = "Row," + "Colum," + "framX," + "framY\r\n";
                    
                }
            }
        }


        public static void getSmallFramCenterPoint()
        {
            float i = 15.005f;
            float j = 70.005f;
            float a = 0;
            float b = 0;
            float lan = 0;
            float lon = 0;
            float row = 0;
            float colum = 0;
            string smallFramCenterPoint = "Row," + "Colum," + "framX," + "framY\r\n";
            for (i = 15.005f; i <54.996f; i++)       //因为是float 如果i=53.998,i++后，i=54.998>54.995,跳出循环(少一                                                行) 原为 i <54.995f;现改为 i <54.999f;        下面同理
            {
                lan = i;
                for (j = 70.005f; j <136.996f; j++)
                {
                    lon = j;
                    for(a=i;a<i+0.993f;a+=0.01f)               //如果a=128.006,a+1f,a=129.006>129.005 ,所以会有129.005，如果改为i+0.993f a+0.993=128.999<129,所以不会有129.005，    下面同理

                    {
                        row++;
                        for (b = j; b < j + 0.993f; b += 0.01f)
                        {
                            colum++;
                            smallFramCenterPoint += row.ToString() + "," + colum.ToString() + "," + a.ToString("0.000") + "," + b.ToString("0.000") + "\r\n";
 
                        }
                        colum = 0;
                    }
                    System.IO.File.WriteAllText(@"G:\RZPU\20141118fishnet\test\" + lan.ToString() + "-" + lon.ToString() + ".csv", smallFramCenterPoint);
                    row = 0;
                    smallFramCenterPoint = "Row," + "Colum," + "framY," + "framX\r\n";
                }

            }
        }
    }
}
