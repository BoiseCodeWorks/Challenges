using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Challenges
{
    class Program
    {

        static void Main(string[] args)
        {
            var data = new string[]{
            "wrqhvxvz",            "fyzrlmet",            "mnoqzwlx",            "nckjlmjq",            "ppgpwuhw",            "gwmlkpsf",            "mraribhd",            "eexeibet",
            "phnkfnoj",            "huvgfryn",            "cctfbymg",            "vuzqijfv",            "csxkasak",            "thdtpgsv",            "qtvawqyd",            "sbrzqyjv",
            "tsgeceoo",            "iersjjvv",            "kkaftivi",            "cohpqdsa",            "jqntmweh",            "ggwfrfij",            "etgdxkpm",            "chpiqqnk",
            "mmubsxma",            "bjbuxerx",            "ppikxcba",            "argnznvv",            "upxrvrws",            "cnutkqpc",            "sjxwbjgd",            "qydjtzwt",
            "fosmuary",            "kbegfawt",            "qrhczgxr",            "xveyfklu",            "fpijdoxk",            "efwixzzt",            "pohwstgq",            "vlacdfij",
            "idyukbzr",            "fomngohx",            "byfhtiqm",            "nygeoydz",            "zzindnsu",            "cqpxyvpx",            "urbwswjx",            "bcrsfufk",
            "ogprzbbb",            "ecqadcfs",            "djtpcvzf",            "omxatkmv",            "qwjmrgiy",            "vmlqsjki",            "eacklrro",            "afvmajbo",
            "yyfzlgqj",            "mnddmztj",            "hgcuzdvz",            "dcdlgcqa",            "ruellrxp",            "stgcbypg",            "cyincneb",            "gfivdkac",
            "imszlrkh",            "aurxrsak",            "upmpveme",            "ooufhdxg",            "gbovipin",            "oekqjihp",            "ffpzbgim",            "wmyllpok",
            "jlxdcsfw",            "rdfbeprc",            "viuyhnso",            "qswyjhtr",            "zqxprsxb",            "mugvrogu",            "swgbpgyl",            "sjxykzhq",
            "bknjvylv",            "sjroofyl",            "aclottku",            "lwzomawr",            "hmnxauei",            "eryjulgk",            "auqbkmsq",            "wjpyinlb",
            "tycjmlzf",            "juhepezh",            "vnhmglwy",            "wflziftq",            "yikhdblb",            "nhzxxdzq",            "dxrthhic",            "uvzqbnol",
            "mcctvnwr",            "npwyyxnd",            "bbnyzojh",            "xgfuoirw",            "jfgjszne",            "rjopxfcm",            "efgfmumj",            "nntsuprr",
            "wxepxebk",            "ekqnppky",            "ceuhjapp",            "xoiukhdz",            "yyqatdub",            "bhbsuewa",            "fgbquatv",            "yaboswth",
            "snbukjjk",            "pynjdknt",            "vvxsotzy",            "yewjntol",            "zziajcor",            "idzqcqdn",            "snomhhsq",            "taleymgw",
            "oaofkdgh",            "uykbobee",            "qgphfpys",            "epmdwvie",            "rswvihev",            "qtsqhqsa",            "onypxjqu",            "lbehiurm",
            "yrqhldki",            "wntmkpxg",            "hvhoqjfm",            "imfrfzzc",            "hlkrbedu",            "eltodvxl",            "fmjbjlzo",            "uudrfilp",
            "nuordysj",            "wxmaadsr",            "zucvyxer",            "yzgztram",            "dvpenypi",            "iugxqkyy",            "tjwuhzom",            "rqvviujh",
            "mvwtwcqf",            "rzzlgbor",            "ldvgepup",            "gxkwrgls",            "pxzmtxes",            "ydnyqvjd",            "ctmbtmpn",            "vzvbnvoh",
            "ogjvwzmi",            "hkutstvd",            "wtkbgjxc",            "zwvdtndc",            "xoewgwrf",            "vuywuoyy",            "tmvgsowx",            "drpazgpc",
            "hdpktjre",            "xhujdiuf",            "usidqmiu",            "paisyipg",            "udgpwuyr",            "xyqujvyl",            "yzymvngz",            "bjsfhkho",
            "kleeufzg",            "boxtwvqp",            "eirtmgdq",            "uyatzfjp",            "eiwaglki",            "zmfdosar",            "kqjhffzw",            "xphspwfi",
            "lkspqenw",            "snostusw",            "pwomwuxx",            "tuwdkyof",            "jafayips",            "fwzjafvu",            "hbsdgbcd",            "hqabjeak",
            "azauvrcz",            "yhsyyfht",            "ncfluumb",            "xkyddact",            "absnaesw",            "nwwgysfc",            "ovkoeoak",            "jfkivysc",
            "vnbxmqmg",            "yxyfjqec",            "fbpxjxoq",            "pwfwufud",            "sxschjcz",            "iemyfvyk",            "jpsozquz",            "xxkbhqfx",
            "ctzdlqim",            "ecvuennt",            "ntsymmce",            "cfammoxo",            "qdeuphqg",            "shhihavx",            "raxrfsjs",            "rffcmsfe",
            "keoiclfo",            "tonhzkka",            "qvifltqb",            "dxgzlvvt",            "wjolvrqy",            "rxrojpfe",            "zjfegcjb",            "ionhbxlk",
            "uttnrfbn",            "elkligyr",            "zxtgftyp",            "zgrlkmbm",            "udynqgcr",            "pwxnwfxi",            "wslxkqmt",            "lzdhoala",
            "cccvdbva",            "sgdusmtl",            "kluxyiti",            "wfekkxph",            "obdeuglc",            "vsizhxgd",            "txldyjzb",            "ytwdfalx",
            "wgdwnlmh",            "nbfwcuec",            "cphqneqh",            "ykmiwxci",            "diqmosuf",            "ycxbayxd",            "uozhqaha",            "foaebowb",
            "whsvmuqm",            "uqycszbo",            "caatmkxj",            "pmrllxgj",            "rpjtthix",            "nkabrxoe",            "dyjavdch",            "bvfwapob",
            "gxdagoag",            "ygsigzqg",            "tojebkhg",            "maywseuz",            "fzycswkp",            "gxuhflnn",            "xdrlwkzt",            "qzdueidt",
            "xrhcqpcx",            "anmlyixt",            "igkeehdq",            "rbbfewws",            "ybzityqu",            "xrsnibvq",            "kiitlldy",            "dnnxpbgg",
            "vghhgbay",            "lttzpsfu",            "mzurjkii",            "tyjyhtbg",            "ymvdocyu",            "errkxbjz",            "kdhdhckp",            "siqzydiw",
            "gaxwpwtf",            "jgsgmbxa",            "meyjbgaj",            "nxdgwanj",            "irypqcfl",            "kwzsqbtn",            "vqbwffro",            "gbhjoydl",
            "mtjeaybv",            "vkejxfui",            "xkrlzagc",            "rvckysna",            "qttzpaob",            "faejrisy",            "oenhtrjt",            "zpajldwd",
            "hdlfphtw",            "uuuztawz",            "priivfke",            "ltqlgmcy",            "wekrahkz",            "arvgglws",            "gmfrdeec",            "bslrhbcq",
            "dwredpeh",            "ripdkqay",            "bkajataw",            "rfwccavd",            "vrcnadbn",            "mxjayvar",            "xppvhrfq",            "rnbkpicv",
            "xlcoaixn",            "ypfgypwn",            "aucydvqh",            "gfmivoiw",            "tdrrgvae",            "nvatvqbd",            "uqnkdtci",            "yvvkoljz",
            "nrvayuna",            "kyjspqke",            "idfgxyxa",            "whhnbvzj",            "untvohwp",            "nbowzeok",            "fojmdmwt",            "hicfolns",
            "nvjmitnz",            "dixbuczb",            "oozreove",            "aogeaoij",            "swqdsqur",            "kuircnkc",            "jommqnij",            "jeoccbrl",
            "srncrgac",            "bflzsoxz",            "crqrvnux",            "aehtnnrc",            "pjfpvctd",            "ooudwhnj",            "oajsxzfy",            "zgocdfqi",
            "skezvrmd",            "hphnrmdo",            "mntkzcex",            "dcezrbsc",            "cwvnaeky",            "zazjhuho",            "hjsicgvu",            "bblytdbn",
            "kuioocro",            "wdmsbnph",            "pglvxlat",            "lfivjfyl",            "tfhuxole",            "axtnimum",            "avbexhov",            "wuwtxwli",
            "ovqriwps",            "kpzzawgo",            "zzrnrxfc",            "erbhfcuz",            "srikwbhj",            "ihkseool",            "ihnzciwn",            "drvqkldw",
            "qjjmhdiq",            "zthvplsb",            "cvzajngd",            "aztvfmpc",            "osvxkdfu",            "hujqnbej",            "qlailyvd",            "aldnonen",
            "mlwgljdh",            "ljegteof",            "hmydlwte",            "dxcbelhq",            "ikxejooi",            "rxfqniee",            "qzfxpqrw",            "qcletmfv",
            "rlnllmwt",            "ldgcvuaq",            "oijbcwzp",            "nsfanzbx",            "zqtxrhlw",            "vruxpbdr",            "zovauywl",            "vfqsnrkg",
            "jseiugwx",            "gplkhkbv",            "vgxaikyq",            "fxuwawnt",            "txpwlven",            "lhdukmwm",            "vqohfdux",            "pwwkcyuy",
            "siyuwkdf",            "ijeceqqv",            "rcafsasu",            "dwmzwajz",            "hpwanjtr",            "aqcumwlo",            "nblfdzch",            "xjmgbuai",
            "dbcmcucf",            "ulqoaslo",            "dilljkcb",            "qzbuzkuj",            "kqaovbws",            "ggaoqcge",            "dkafdhok",            "kiwmtsle",
            "pmosnoov",            "bqzwbyff",            "jzbkupuq",            "loruoeuj",            "znxhxcbq",            "zuiojajs",            "nkzxcjnb",            "byfmovta",
            "lexozwii",            "mmiirvzo",            "wxdmazhu",            "tvakysqv",            "fcclondf",            "laovojik",            "liwlmxma",            "fhfyuwhu",
            "dhnbftia",            "hhjgkstn",            "xievywrd",            "ytggugmi",            "fueqzuxp",            "cntcbskl",            "moevqzch",            "rkvngfzu",
            "vyoyrmnz",            "fsmfxqux",            "kjrcqres",            "wbwgstkj",            "bbpkbyfv",            "odlwmtdm",            "yvwxzpkp",            "tglceron",
            "pfqhznpf",            "cjvguvna",            "awatckgf",            "jjuedfcr",            "xsmzexyx",            "zolugtkn",            "equadjbw",            "yzuwbeip",
            "juokhxyh",            "blbzigrg",            "xiiqmrfr",            "wpklubhl",            "dnklxihu",            "dvypukjj",            "gezdwsyq",            "ijpsmlhy",
            "haybyxgt",            "ttrpwsia",            "xsmuumcy",            "zjcjcfgn",            "qcyfmzxn",            "jbpiesjd",            "imsgjvbe",            "bluqigdj",
            "pkjtbwrz",            "ghdqwhof",            "qqcyrcmt",            "nwqbpohw",            "wtdmhjpz",            "kysorzis",            "beybysab",            "wzotkcsl",
            "rkxcjtxw",            "kxdovhby",            "nwbmwfvw",            "ldgnxdzg",            "fvkssaql",            "gwnpsneo",            "kzdageby",            "tvalcxyg",
            "vudemgvl",            "nhsqjdry",            "ihbwfzmq",            "ulzxzqpr",            "ulyisqeh",            "gibzsqab",            "qlbvivbk",            "zfjbeimz",
            "uwwkbmad",            "jysiepul",            "pcttcpfb",            "ikigjtum",            "ebnjregv",            "wlnojjdl",            "jseorxzw",            "jadngcyb",
            "chblsorv",            "atsykhzy",            "llmwiiue",            "lncwmxbm",            "uaprvgtu",            "fsfbhhna",            "qekriahp",            "cprovrro",
            "arkzaotx",            "cqkmiisd",            "byasehtp",            "mquxvaus",            "yqdboakk",            "fcbmnmas",            "ndgancyd",            "mqbhpwky",
            "bqqnrysa",            "heevqgpx",            "wenamdlt",            "geqpvmvy",            "awohkyss",            "csauzidz",            "rzbxnqxo",            "lijyetnn",
            "szhywdzw",            "bvspeaot",            "cassrzgo",            "ebniprcj",            "jkgqnrmt",            "kanfkldg",            "tatiqhyp",            "kjrnsxxf",
            "tigsmyql",            "dpiwuvgd",            "mysstyqk",            "ggmceolm",            "uykudpjq",            "lqcfbupx",            "bspqglas",            "adlikxti",
            "ytkklkgs",            "hagxejlb",            "qawjetxs",            "mfozming",            "mijryfrm",            "aiqisdzo",            "oizwdmba",            "fmwhxvyn",
            "nbpvnnqu",            "uucpiqnr",            "derohmtm",            "mtvvlkwb",            "odofsftu",            "otdpquza",            "ieuqarfj",            "efbllxnl",
            "piyhprln",            "zzhuyevt",            "xggfukpg",            "oagdqlte",            "jcaknznq",            "bmqvzzpm",            "gqccntfm",            "kejcxspk",
            "eghjfubo",            "jpesccrp",            "lptxbsjp",            "lkqdahjg",            "gllipbpw",            "gmtpkpbh",            "vskklchk",            "hkujjpqf",
            "onqsydhq",            "abymijve",            "setxngek",            "pylgwuhu",            "rvmcnudu",            "zkoigkmp",            "jhufctqm",            "rjlebecw",
            "kfrcyvsg",            "gdvswlmx",            "ddneodvc",            "eleaatkz",            "xdrrnsmo",            "eavdleuh",            "snuapqlh",            "qfprvzlf",
            "jwtxoteb",            "xhmeonrl",            "oomepucp",            "voldiamz",            "pgctnnvi",            "zxctfwmu",            "ssvzhjjc",            "iszyacdg",
            "kwhtrkug",            "tsfcxlah",            "jhnpuzwv",            "vgvytgdv",            "xppvelhv",            "lczyglmi",            "mzyncyji",            "fktibrns",
            "tnpbpekf",            "htcfrtea",            "iehqohts",            "ofhqjvss",            "etoxthqs",            "tcpnurrf",            "tquperre",            "icdggorv",
            "grbpboje",            "hrtqhokf",            "prxttopc",            "smaptpvf",            "tcahqpmd",            "tmaizzjw",            "hnjiwcvm",            "qzmitpgs",
            "ssmfzilr",            "glxqqwis",            "umeygdrp",            "qhqgfocl",            "rmxlqigp",            "vcxozjsn",            "mviznnhr",            "islgcrgm"
            };
            Console.WriteLine(Repeater(data));
            Console.ReadLine();
        }


        private static string Repeater(string[] data)
        {
            /**
             * Something is jamming your communications with your team. 
             * Fortunately, your signal is only partially jammed, 
             * and protocol in situations like this is to switch to a 
             * simple repetition code to get the message through.
             * 
             * In this model, the same message is sent repeatedly. 
             * You've recorded the repeating message signal (your puzzle input),
             * but the data seems quite corrupted - almost too badly to recover. 
             * Almost....
             * All you need to do is figure out which character is 
             * most frequent for each position. 
             * For example, suppose you had recorded the following messages:
             * 
             * eedadn             drvtee             eandsr             raavrd
             * atevrs             tsrnev             sdttsa             rasrtv
             * nssdts             ntnada             svetve             tesnvt
             * vntsnd             vrdear             dvrsen             enarar
             * 
             * The most common character in the first position is e; 
             * in the second, a; in the third, s, and so on. 
             * Combining these characters returns the error-corrected message, easter.
             * Given the recording in your puzzle input, 
             * what is the error-corrected version of the message being sent?
             */

            string word = "";
            for (int i = 0; i < data[0].Length; i++)
            {
                string letters = "";
                for (int j = 0; j < data.Length; j++)
                {
                    letters += data[j][i];
                }
                word += letters.AsParallel().GroupBy(x => x).OrderByDescending(x => x.Count()).FirstOrDefault().Key;
            }
            return word;

            //    char[] message = new char[data[0].Length];

            //    for (int i = 0; i < data[0].Length; i++)
            //    {
            //        Dictionary<char, int> letters = new Dictionary<char, int>();
            //        var greatestCount = 0;
            //        char greatestLetter = ' ';
            //        for (var j = 0; j < data.Length; j++)
            //        {
            //            var letter = data[j][i];
            //            if (letters.ContainsKey(letter))
            //            {
            //                letters[letter] += 1;
            //                if (letters[letter] > greatestCount)
            //                {
            //                    greatestCount = letters[letter];
            //                    greatestLetter = letter;
            //                }
            //            }
            //            else
            //            {
            //                letters[letter] = 1;
            //            }
            //        }
            //        message[i] = greatestLetter;
            //    }
            //    return new string(message);
            //}
            return "";
        }



        private static int GroceryQueue(Queue<int> customers, int registers)
        {
            /**
             * Calculate the most efficient time possible to checkout all customers
             * given n registers
             * ([5,3,4], 1) == 12
             * ([10,2,3,3], 2) == 10
             * ([2,2,5,2,1], 3) == 5
             * here n=2 and the 2nd, 3rd, and 4th people in the queue 
             * finish before the 1st person.
             */

            //int time = 0;
            //var inUse = new List<int>();
            //var count = customers.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    if(i < registers)
            //    {
            //        inUse.Add(customers.Dequeue());
            //    }
            //    else
            //    {
            //        inUse[inUse.IndexOf(inUse.Min())] += customers.Dequeue();
            //    }
            //}
            ////return inUse.Max();

            //Dictionary<int, int> r = new Dictionary<int, int>();
            //var open = registers;

            //while (customers.Count > 0)
            //{
            //    customers.de
            //    var inUse = customers.Take(open);
            //    open = 0;
            //    for (int i = 0; i < registers; i++)
            //    {
            //        var register = inUse.ElementAtOrDefault(i);
            //        if (register != 0)
            //        {
            //            register--;
            //        }
            //        else
            //        {
            //            open++;
            //        }
            //    }
            //}

            var time = 0;
            var max = 0;
            while (customers.Count != 0)
            {
                var cTime = customers.Dequeue();
                time += cTime;
                if (cTime > max)
                {
                    max = cTime;
                }
            }
            return time / registers < max ? max : time / registers;







        }


        private static int[] RemoveDupes(int[] nums)
        {
            /**
             * SOLVE IN O(n)
             * [1,2,1,3,1,4,2,3,6] == [4,6]
             */

            var numberMap = new Dictionary<int, int>();
            var uniques = new HashSet<int>();

            foreach (var num in nums)
            {
                if (numberMap.ContainsKey(num))
                {
                    uniques.Remove(num);
                }
                else
                {
                    numberMap.Add(num, num);
                    uniques.Add(num);
                }
            }
            return uniques.ToArray();






        }


        private static List<int[]> IcecreamParlor(int[] menu, int cash)
        {
            /**
             * Solve in O(1)
             * [[0,5], [2,4] [2,6], [4,6]]
             * Chocolate: 3
             * Vanilla: 2
             * RockyRoad: 5
             * Praline: 6
             * RumRasin: 5
             * BaseballNut: 7
             * CookiesNCream: 5
             */
            var indexes = new Dictionary<int, List<int>>();
            var pairs = new List<int[]>();
            for (int i = 0; i < menu.Length; i++)
            {
                var scoopPrice = menu[i];
                var diff = cash - scoopPrice;
                if (diff == 0)
                {
                    pairs.Add(new int[1] { i });
                    continue;
                }
                if (indexes.ContainsKey(diff))
                {
                    var diffScoopTypes = indexes[diff];
                    for (int j = 0; j < diffScoopTypes.Count; j++)
                    {
                        var diffI = diffScoopTypes[j];
                        pairs.Add(new int[2] { i, diffI });
                    }
                }

                if (indexes.ContainsKey(scoopPrice))
                {
                    indexes[scoopPrice].Add(i);
                }
                else
                {
                    indexes.Add(scoopPrice, new List<int>() { i });
                }
            }
            return pairs;
        }


        private static bool BalancedBrackets(string code)
        {
            //SOLVE IN O(1)
            //([{}]) == true
            // {} == true
            // [} == false
            // ][ == false

            //code = Regex.Replace(code, "[A-z0-9 _]", "");
            //if(code.Length % 2 != 0)
            //{
            //    return false;
            //}

            //string half1 = code.Substring(0, (code.Length / 2) - 1);
            //string half2 = code.Substring(0, code.Length - 1);
            //return half1 == String.Join(half2.Split().Reverse().ToString(), "");

            var opens = new Stack<char>();
            var inverses = new Dictionary<char, char>();
            inverses.Add('[', ']');
            inverses.Add('{', '}');
            inverses.Add('(', ')');

            for (int i = 0; i < code.Length; i++)
            {
                var letter = code[i];
                switch (letter)
                {
                    case '(':
                    case '{':
                    case '[':
                        opens.Push(letter);
                        break;
                    case ')':
                    case '}':
                    case ']':
                        if (opens.Count == 0)
                        {
                            return false;
                        }
                        if (letter != inverses[opens.Pop()]) { return false; };
                        break;
                }
            }
            return opens.Count == 0;
        }


        private static int[] NeedleInHaystack(string str1, string str2)
        {
            //given a haystack and a needle find the indexes of each needle character in the haystack
            //rules you can only use the same letter once
            //str1 = hNaEysEtDLacEk, str2 = needle
            //output == [1,3,6,8,9,12]
            //if you get it can you do it in O(n) time complexity

            //var output = new List<int>();
            //var str1Arr = str1.ToArray();
            //for (int i = 0; i < str1Arr.Length; i++)
            //{
            //    var currChar = char.ToLower(str1Arr[i]);
            //    if (str2.Contains(currChar))
            //    {
            //        output.Add(i);
            //        str2.Remove(currChar);
            //    }
            //}
            //return output.ToArray();


            str1 = str1.ToUpper();
            str2 = str2.ToUpper();

            //int[] output = new int[str2.Length];
            //int[] letters = new int[26];
            //string[] positions = new string[26];
            //for (int i = 0; i < str1.Length; i++)
            //{
            //    var charNum = (int)str1[i] - 64;
            //}

            var charCount = 0;
            var output = new int[str2.Length];
            for (int i = 0; i < str1.Length; i++)
            {
                var currChar = str1[i];
                if (currChar == str2[charCount])
                {
                    output[charCount] = i;
                    charCount++;
                }
            }

            return charCount == str2.Length - 1 ? output : null;






        }

        private static void Kaperkar()
        {
            /**
             * Take any four-digit number, using at least two different digits. (Leading zeros are allowed.)
             * Arrange the digits in descending and then in ascending order to get two four-digit numbers, 
             * adding leading zeros if necessary.
             * Subtract the smaller number from the bigger number.
             * Go back to step 2 and repeat until the number becomes 6174
             * Max iterations will be 8 for any valid number
             */
            int KAPERKAR = 6174;
            int i = 0;
            string input = Console.ReadLine();
            int.TryParse(input, out int n);

            while (n != KAPERKAR)
            {
                string x = n.ToString();
                if (x.Length < 4)
                {
                    x = new string('0', 4 - x.Length) + x;
                }
                //do stuff
                i++;
                var smallS = x.ToCharArray().OrderBy(d => d);
                var largeS = x.ToCharArray().OrderByDescending(d => d);

                int.TryParse(String.Join("", smallS), out int small);
                int.TryParse(String.Join("", largeS), out int large);

                n = large - small;
            }
            Console.WriteLine($"Iterations: {i}");
            Console.ReadLine();

        }

        #region HasPair
        private static void HasPairRunner()
        {
            int[] nums = new int[10000000];
            int i = 0;
            Random r = new Random();
            int sum = 3000;
            while (i != nums.Length)
            {
                nums[i] = r.Next(0, 3000);
                i++;
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();
            System.Console.WriteLine(ArrayPair(nums, sum));
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            System.Console.WriteLine(elapsedMs);
            Console.ReadLine();
        }
        static HashSet<int> set = new HashSet<int>();
        static int[] f = new int[3000];
        private static bool BadPair(int[] nums, int sum)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var currentNum = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var nextNum = nums[j];
                    if (currentNum + nextNum == sum)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private static bool HasPair(int[] nums, int sum)
        {
            /**
             * Solve with O(1) time complexity
             * ValidPair([-1,2,5,18,8,14,22], 20) == true;
             * ValidPair([-1,2,13,1,2], 28) == false;
             */


            //River O(2)
            int lowbound = 0, highbound = nums.Length - 1;
            while (lowbound < highbound)
            {
                int low = nums[lowbound];
                int high = nums[highbound];

                if (low + high == sum)
                {
                    return true;
                }

                if (low + high > sum)
                {
                    highbound--;
                }
                if (low + high < sum)
                {
                    lowbound++;
                }
            }
            return false;
        }
        private static bool HashPair(int[] nums, int sum)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var dif = sum - nums[i];
                if (set.Contains(dif)) { return true; }
                set.Add(nums[i]);
            }
            return false;
        }
        private static bool ArrayPair(int[] nums, int sum)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var dif = sum - nums[i];
                if (f[dif] != 0) { return true; }
                f[nums[i]] = nums[i];
            }
            return false;
        }
        #endregion
    }
}
