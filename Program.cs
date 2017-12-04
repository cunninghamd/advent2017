using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace Advent2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Advent Day 1:");
            var advent = new Advent2017();
            var puzzleInput1 = @"3893445835429722678558456317563893861752455542588369533636585887178232467588827193173595918648538852463974393264428538856739259399322741844613957229674619566966921656443476317729968764183945899765294481327998956154956571467872487576314549468261122281384513266834769436913544431258253346374641589492728885222652146158261225296144835682556133922436438188211288458692217737145834468534829945993366314375465767468939773939978272968388546791547526366348163672162245585168892858977723516752284597322176349412485116173844733679871253985762643852151748396593275274582481295864991886985988427966155944392352248314629138972358467959614279553511247863869663526823326467571462371663396188951696286916979923587358992127741723727623235238531991996999181976664226274715591531566495345212849683589582225465555847312199122268773923175183128124556249916458878785361322713513153175157855597289482439449732469754748544437553251412476225415932478849961897299721228198262823515159848941742786272262236888514421279147329383465929358896761449135917829473321834267122759371247338155787774952626616791265889922959653887288735233291968146648533754958199821789499914763279869931218136266492627818972334549751282191883558361871277375851259751294611921756927694394977764633932938573132221389861617195291742156362494769521829599476753198422283287735888197584327719697758442462886311961723849326959213928195182293316227334998926839139915138472514686689887874559367524254175582135318545912361877139367538434683933333264146289842238921989275112323681356256979576948644489986951538689949884787173194457523474156229389465725473817651516136514446513436419126533875125645855223921197481833434658264655912731133356464193251635637423222227273192628825165993827511625956856754776849919858414375874943572889154281862749595896438581889424559988914658387293414662361364793844213298677236787998677166743945812899526292132465751582925131262933636228593134861363493849168168765261647652342891576445292462341171477487223253795935253493869317616741963486473";
            Console.WriteLine("The sum is: {0}", advent.Day1(puzzleInput1));
            
            Console.WriteLine("Advent Day 2:");
            var puzzleInput2 = new List<string> {
                @"1919 2959 82 507 3219 239 3494 1440 3107 259 3544 683 207 562 276 2963",
                @"587 878 229 2465 2575 1367 2017 154 152 157 2420 2480 138 2512 2605 876",
                @"744 6916 1853 1044 2831 4797 213 4874 187 6051 6086 7768 5571 6203 247 285",
                @"1210 1207 1130 116 1141 563 1056 155 227 1085 697 735 192 1236 1065 156",
                @"682 883 187 307 269 673 290 693 199 132 505 206 231 200 760 612",
                @"1520 95 1664 1256 685 1446 253 88 92 313 754 1402 734 716 342 107",
                @"146 1169 159 3045 163 3192 1543 312 161 3504 3346 3231 771 3430 3355 3537",
                @"177 2129 3507 3635 2588 3735 3130 980 324 266 1130 3753 175 229 517 3893",
                @"4532 164 191 5169 4960 3349 3784 3130 5348 5036 2110 151 5356 193 1380 3580",
                @"2544 3199 3284 3009 3400 953 3344 3513 102 1532 161 143 2172 2845 136 2092",
                @"194 5189 3610 4019 210 256 5178 4485 5815 5329 5457 248 5204 4863 5880 3754",
                @"3140 4431 4534 4782 3043 209 216 5209 174 161 3313 5046 1160 160 4036 111",
                @"2533 140 4383 1581 139 141 2151 2104 2753 4524 4712 866 3338 2189 116 4677",
                @"1240 45 254 1008 1186 306 633 1232 1457 808 248 1166 775 1418 1175 287",
                @"851 132 939 1563 539 1351 1147 117 1484 100 123 490 152 798 1476 543",
                @"1158 2832 697 113 121 397 1508 118 2181 2122 809 2917 134 2824 3154 2791",
            };
            Console.WriteLine("The checksum is: {0}", advent.Day2(puzzleInput2));
            Console.WriteLine("The dividend checksum is: {0}", advent.Day2Part2(puzzleInput2));
            
            var start = 325489;
            Console.WriteLine("Advent Day 3:");
            Console.WriteLine("The number of steps are: {0}", advent.Day3(start));
            
            var passphrases = new List<string> {
                @"vxjtwn vjnxtw sxibvv mmws wjvtxn icawnd rprh",
                @"fhaa qwy vqbq gsswej lxr yzl wakcige mwjrl",
                @"bhnlow huqa gtbjc gvj wrkyr jgvmhj bgs umo ikbpdto",
                @"drczdf bglmf gsx flcf ojpj kzrwrho owbkl dgrnv bggjevc",
                @"ndncqdl lncaugj mfa lncaugj skt pkssyen rsb npjzf",
                @"kdd itdyhe pvljizn cgi",
                @"jgy pyhuq eecb phwkyl oeftyu pyhuq hecxgti tpadffm jgy",
                @"zvc qdk mlmyj kybbh lgbb fvfzcer frmaxa yzgw podt dbycoii afj",
                @"zfr msn mns leqem frz",
                @"golnm ltizhd dvwv xrizqhd omegnez nan yqajse lgef",
                @"gbej rvek aehiz bgje",
                @"yej cphl jtp swe axhljo ddwk obwsq mnewiwu klddd",
                @"ipiev henods rpn qfpg gjfdgs zcpt sswab eosdhn teeil",
                @"gzje ydu oiu jzge udy sqjeoo olxej",
                @"mgn gox tcifta vzc lxry gox gox mvila qdl jipjnw dvu",
                @"hxk xhk unhdmdz yomze povrt nbww bxu qqsqc rvuk tgffy twddm",
                @"fyx fyx nzkm fyx",
                @"ymnoc zogudq yncom tqrob sidvy dfuu ccjpiej yidvs",
                @"bxebny akknwxw jeyxqvj syl cedps akknwxw akknwxw zpvnf kuoon pnkejn wqjgc",
                @"kcebrkj zmuf ueewxhi mgyepbr nleviqc dez",
                @"argavx fqguii gebohvw klnrq rkqnl goevhbw",
                @"ywqi abwi eswph nlplbl pswhe lnqx fpgk lllnpb",
                @"abpb mpkw ampey yapme xnuyj",
                @"tmuaq asd bhbs sqmbsnw wsbnqsm ydwdncn rpa vrllkh",
                @"dnltf cck djy ydj",
                @"wywwl scezo clowuz dkgqaj dohyzcp",
                @"diimshr vlmsnlj whqb dkicau ckdaiu terp kgcii npqc vvzrqzv nol",
                @"wfpxe sqf tbb ruqpcq zfgb",
                @"kajykuz tsxgtys vuz kglmgg ihnnn plyjxj rcrvo mij plyjxj jqiur",
                @"pxs hmet dwgvd mvhkvn cjxg yvid vmhnkv kwxz rfemsua wdgvd okixk",
                @"lzwxas ddtyeh ivyama crrhxdt hedytd jfw",
                @"vjfv oyd fvjv kfwlj mradbx mckseee xradmb",
                @"llga yytxyvj lstspek lstspek lstspek",
                @"fabgf wgop fabgf bvsfoaw",
                @"grqnbvo tntomdw hizg tmotdwn",
                @"mau ufkw cxfi rhehj ebe xyv rhehj acxngo arl qtl rhehj",
                @"kbkto stqjtm tpcwshj saerkrt pffj dthp pfjf axc gwmmfdw glnqtdy xmskw",
                @"veff zqm hzhxap lgwnwq twsdk mqz xbbarbv cdx fhnwt qjcji bbvbrxa",
                @"fjw eds hofskl nkbsv des hvx xyn",
                @"qzort qzort qesz rtq oonk vwzlw wapoj ifr cta",
                @"pja hvy nhjg paj smtfe fmtse",
                @"xvi tcjj xvkjtab nqftt aumijl xkd cmilegf hvsmodx uuo igmcelf mslkq",
                @"mdhezgv lelzy kzfvsqu hvmvaxw pxiqjc hvmvaxw kzfvsqu",
                @"hsicsav csshrhx znojm eapi lhmzq bbwnz seao gfk azk",
                @"pup xtgjyzy wqt ijeektl",
                @"ktwh qdegzs btj pfwzzho",
                @"xdkmdm izqtjrr iqbke vtp",
                @"fmrbpdr zpccv tmtwx tmtwx tmtwx bys",
                @"ehphfgq idd ehphfgq ehphfgq uphe hvrc jcscne nbnslqy",
                @"xzqucgj fcih fljk barz lvln hcfi azrb",
                @"cmfmclv mfgvifw rnxgn jpg bsnq wnduzj ymsdx smdxy pqomf",
                @"rlqsm qrsml emts qsmcowv scmvwqo",
                @"tshzkpa zwtpda ftsiwo nil tpawdz kjpa ptzashk",
                @"mnep sfc swjawtd vnwud gyulluw zpa kmwyvln evd btnmoi dnwe",
                @"jwq scepq redoxmw rbdzsa wlkzso kxpm bttg vxuc moxwdre ijtdd rzsabd",
                @"wpvo dsjox amuwjm pls lgwksva ctakgpl rmsjj lzwwpr zzm udg",
                @"bji obbn tmwyc afpmkxr glvrd kahhgpq rna qkxyntp vmd mloshc",
                @"ymq rtnr nxjzm pqiddrn qmy vgxw ull",
                @"mmzk ikge zhtzhs xyo qwe lll gjjm icetq qgrr mzwqa knec",
                @"kxomfck idlh xrbowo nyetbnl qskh xuwkkxe upmmmf zhvuyp",
                @"srcwyhl czgr xmhuws jueyh xcuib xhsuwm bxuic",
                @"crkueh beyxopz xpyozbe dxgadw qktmce rjropjg",
                @"lbktun imdpcp fkssp fhcpt fehho jqdnt aoewa",
                @"jmun pynzjo trs ijwcc pelf oft pcsqdxg zvql",
                @"mneaaq vjrg jidlrzz phd mvxpivd ldkhu",
                @"sao xqw nrukn gatkz quscpsx vmz oscoeb",
                @"goi wzxhb rrk aylqqcd mlcbvvf ororn heptid kdu byevr",
                @"qsj lsbieef deez vzwdx hez iwd",
                @"lmgfb keqt mqbsuis ogrr errbi xiqe xsszacp",
                @"ato hmk zfjaj kmh plxup cida dqd pfwh nkbxvpr buajw pxkrvnb",
                @"cli bdwu vrwott vowtrt grle",
                @"zisgks ciuaqr zvk tcb kvz ugmtv",
                @"oegrojm wofpwp gnaocx rweyull ellhwow dtefylf dqsz oiw varr bcirpf oxusz",
                @"oydkmib oydkmib yefts gbl gbl",
                @"sruwjk pgkrp kea gppkr zdcky cfljh",
                @"obpxbax jhpcrj slcsa lgd fborz vvpaus wsrpsws ifijuzo",
                @"rixz jwh uhdaf hoacv hdfua",
                @"kntk qprmfow kntk tbmcjx",
                @"vnqe ooyxtb ixl hdmnpn orpz ykspl xromvj kowtq wmho gquos",
                @"ynk xjjqw sut lmtub bmtlu zdo dztlk bpkuul smhpx rbczg",
                @"zals csdbe sbj dibicq kdfwwt",
                @"coyy pjddlfc lwvhyms ldjdcfp ryubz kfwst dqjrjja jtv jjjaqrd",
                @"jaexhms iqoiln ewgyr exmnrr fsr lgmyy fdofhn",
                @"pjgyn hfoz zbcnz nczbz",
                @"ovntivq vcey vdrkse giu ohyaxy ionyy fvpn yvwrgrv qta",
                @"yelpz htbk njgeyub tggh mdthzp fwyux rduqli twlhfp pnh gywif ttn",
                @"yxhsbil vplsmmx rgtq grsf lyibxhs hctnkfr awg lmloz jroy lpgb wga",
                @"kzytass szyksat tyskasz ehmhhu",
                @"jkus hwjv ymnnkk yffugg cvtnits gbl lywkn szihcn dbrbalf rxqpbqh",
                @"koyfcef wkom mwok qgjrytl",
                @"slmhry lcr slmhry lcr",
                @"mvoxbt cfkz purnsui xar ouhtc thbx",
                @"xcdifw kvvxyrj knac qmypw bou tmukqy eusgaoo bktiu",
                @"ablgnhb axumg bwpxnjp zqpc vtw ghhoxu zqpc znfpvl ghhoxu jlg ntdk",
                @"vmvc cdkhrx cvz rvxk mmcuo udpcayd lsmm gufduzt linj",
                @"mgyeqkv hqionh rgnqgz kkc qrgnzg egkmqyv topdp",
                @"koa dimwx gjxa atlfdy",
                @"uuez ueuz zeuu ezo daq",
                @"ofpaw bgomvmt mqa dexpy mbipd epyzcoa nuwrh vwly xppz qkjrleo rwhnu",
                @"wok grxk lchvtg plrzr lwaax cfeu ijapws dmkdwc cfeu",
                @"zkd hysxxip hlydw wicsvy gbwoaw dapre ktjn dzg uri",
                @"blzh hblz qgmjceg fyf",
                @"vkhpn xnc ogva pjrh cxn hkpnv",
                @"aja cldzta tdcazl lorr fwmxxh knilf ges tdhp gnlo vihrl",
                @"ucpr peair nlbmc msfg",
                @"trv ppq bmo xqd vbui yegsr xqxawu fvuz aclhspo wnan",
                @"loiq fvg kare rmgq hir rzo ossd ziw renh ygtkjys vda",
                @"xmans kio alexs ujekfl vvf ddghn",
                @"fcxvsf bjuytet zrzsobo uhn mlfzhlq bjefs",
                @"zys htlqvky plno pbcqfuf fjwc vshkxrl lonp lyzmy dqmui vyyc glad",
                @"tlc krhcter krhcter bolk tlc opryl",
                @"idcii dverl uswb wusb zgax zhbt gjsnlso yhs",
                @"cti npri rcbxjdw ollj nirp ghfvxzh",
                @"blyhug aflnrrz zudyw ccnstq cyoju jxtqoj ntuknjq gunjiwy ycuoj igac cqctns",
                @"bul yehpnw jifjrhc ifetu ufrodp hqzpeqf hdvpc qtvgxg ibb wcxsitx xztshb",
                @"xzct scetn eoaufyo jtudgkx xrpgxip lpubtq juezstc nuc hokswh obkf ipbu",
                @"nfq lwpmn qltal xnphsqs zlrgf iewtrtd mqzsob duokpy kfbqs icg",
                @"vil zjz xkqrvni uay ystq",
                @"terrrnt lnfg clm lbs ptpiy ybcuup ayzjm pqugx lmc yppit mbf",
                @"dtajh vqivg vnblt fmn qxkw stiwna pclrrr fro khu wbslnqp tjyosu",
                @"uqlehn tjuiy obt uedct bbwiq uxndqn",
                @"hiqfovy xiimca zwne ivunvjk cmctzi mxnnrx dclib xzaoq ieztkg",
                @"shpr xuorihj chuwq poadbo mhtvex gymsp iltgl sypjfua fmyh sgiv",
                @"alv nxjt txnj bhact",
                @"vjvtrex obmrxk fgigs meixbc fggsi awi rxdjpeg",
                @"ypwo oicmbdw xbpeeyj uabzj cjvutvc oicmbdw immtmks",
                @"exijri hogl epr gzdqyur xiiejr pre ihzlgzu",
                @"rlh qfhx lrh qmvrx",
                @"kogq okhd mivmivb mivmivb okhd",
                @"taekt nhjaa znbaahn iaospxy jawwf",
                @"ytdvq ghtqwud jkiig mre kzmmjxu jba nwpykc",
                @"ktyzr aczd exgadhb uinrgac izazxky yyfe",
                @"yrifb qgc lsiuapg teyelxn ugezu",
                @"wdzkc ltx fkhncb hwrecp kfbchn sfcpc hjvq",
                @"rjdjyt ahwxh nvggsmx lmz oshd xbcik powse ahhxw yhiq gxmgsnv",
                @"qdr qjnam gag qjamn kooek mqnaj",
                @"pza gml opf ilfbblu kjp luilbfb rhfrzgp ixagj ofp",
                @"yphz runy dhull bozcsgk wfxekrd akgkbz urcphc",
                @"tfyxwol lhcl npik beug",
                @"szatel yfkve yfkve lzqhs",
                @"yjzqon pcjibu bdncmcl kczuymm pbmg nyn",
                @"rerqvs aoxucwi pmstl sstawu joqu abvcchg mvgjn mslpt vhmfkr utusuh",
                @"gqbec jjpqdh yeaiavi nledfi jhzwc vyxjpf momnm vnknjs nvgjzik ipm",
                @"psirt rispt lrkgma irtsp",
                @"jbbaph xvunete gsvnr mjd ifxhpry cpsx hmuokkx vhcm yth shrrl zbhd",
                @"gfa bcmlxtf sqyanrp cugg qxfvftz pbl ujsgc jajxltm gugc oil",
                @"xjuhyg aht vmyvzhh oby oyb ybo xbybgmx",
                @"atfk qjudfzz mky tfy",
                @"nxk yzy jqgg qxgjt bevvvv efi xcbw bohc zaqlqjq",
                @"hdc qpnx ygmtqw acvoa udboxw dhc klh mwgpk xfpuri",
                @"cycgbkq skwhyf skwhyf veaqss skwhyf",
                @"jnezf jowjt vsdu uck scgxd fvopomz vfajslp",
                @"djvi epgkyqn apzd cpm owm kpwih fsr adlhqu jicp pmc",
                @"erxlmhj wqxvofi ugj ttrmtsb",
                @"omku vmrgoy tdicbje ewml dfnwbap",
                @"gpih pyt ptsmzc gmdbu rqxkqmz objm nurxjz oozbere ztxug koth",
                @"jpnl jpnl dmeh qed",
                @"intdwv ksgw qwlzhq zpd lrl mwjl dozrjwq aujbet bsnf vhqyg",
                @"eqs uot qyz xor aem kmrh mrhk jqx tsbrf",
                @"irytjab mdzm qbb kkjt gofiwo xgbovg kyeyxqn tcks tljhx",
                @"zgejy qodgah nqavvx xnigdvt",
                @"eqve bizrxq lkhz yzwxgt nwe zfe sxypkz xnssept",
                @"bxqn lkfg yfxbszo sphwifz wnj crhbq dvokzw",
                @"vzn afatwye ogzvnu vnz rfjba xtugnj kpbgly ocsjd",
                @"xrc cxr rahv yvhk khyv bed ctgbuq cmqwpqa jlbg hpj vmesvw",
                @"jbshkya dgqw lfl mzcch jxsg czcmh ifruvlw ufwrlvi xcczlol cqqchmr",
                @"rbk mhn tnmqdc sxnnn kvoa mhn sxnnn mgemob ieiyajs",
                @"cqi ghxg ghxg ghxg",
                @"uqwdxn qli gdtkngp gnptdgk udxqwn",
                @"dmcczr dnjaqc qwdta rhrbi hkdwe qdjcan peic iulaz xns",
                @"tcmppb nzq ecy sitdud nft ecy afrbf wvnc vmfpzx tcmppb cgb",
                @"plitv efnpq mjqav nrxxo izg lpitv rwbzdo rdbzwo",
                @"day dntga adtng agndt hhvtd",
                @"yrg iudsh gyr ryg",
                @"qttyeew tco flq bszw jkzftc wdh efcwnp mja rfmju",
                @"moch prkze uslzyv plhjuy kxczyq qlmm hgq",
                @"xtg ypz izy ixg bvs xlqgj xcy sepza abiylsg",
                @"wxvsxn bqag jnlzgxq ikxwa dfd plqxl xlgqnjz nuqvoyb emhodso gaqb",
                @"bzjdsm xmxkj fhuqn gauyw ntl kjxmx zcxdr vrds",
                @"ofjcc uxyzlk ofjcc ofjcc",
                @"zwosex kkvwobl cpudsmb kes zklf bayuojr otqnyr udbbs",
                @"iqpvzh ybds piovrh oivprh voprih pov sfl",
                @"upns cpeelht xboyk itb hsxdmt dnwgfbw upns fygf kwdpxzm mli dyy",
                @"djwutl sikh shki ikhs gecd jqkon trqyw",
                @"prbbdf vdp bvvfjcg ydqb muxygg",
                @"vhpurzn psemqe xwqfk hrvonxu nxkxacq",
                @"xicmhss tnpja qiad woipfy uvadcq usljh hzgs jntvfv wzikk",
                @"mmupc twntp upcmm pumcm",
                @"qnisuzy lppnfd uiqr eyqbain uxlp eyrfwjo olgkrps sbikam zin vckr",
                @"nmokl skfni jcdfot njzqeaj nqzjjea",
                @"slmaxx offfzqp wudicrf nfn rwfcdui cwirufd",
                @"paffi murnjd oyj lbtjdqe babuas dtqh qkt stapzl yrqlp",
                @"eedc rig zmnfmn edec ecde",
                @"bcfdf edovdj lacx nzvze sordvxj ybs ujh zvvvp rzstejg ueosuq",
                @"xrrfsd okuvem znzlvmb jwzcb bfg bmuxbc qzwfry",
                @"pqgxybd cvgra acgn ocd ancg fvfcx fbb bfb zfzv",
                @"tmmv mpywyg fwl bnvcv lcnv flw",
                @"xxnfbro papc ianru beuzx apcp rnt",
                @"wuyhycj nrnc cka ebg rncn rvo wcyhjuy",
                @"thh cmoog hwf imqfp okzpxd",
                @"rzxiqt rtaiy ytria tyria",
                @"cjkmro myif myif xyirn aqxlol wlhwibi dhzsen pzwgm bfbz bufjs qwffg",
                @"mxhiui umiihx zomyll vfieccs",
                @"yyntf rjk iivgj mwh rjk",
                @"dsshx wsmaxhc xcwuelh rdsgtr wsmaxhc rgtsfj",
                @"rdh nwlxiwu xsjzbpr bsgps",
                @"ufyo vqtzkg kpeohu mxzt fyuo gawgaq youf",
                @"hzbhut bxsnjwb zuhhbt zhhtbu",
                @"pdz sgntypg ragev hrrji goitft yphnebs xjzoo sqf jsuzijq dsocb hcxg",
                @"pptsq woomypc woomypc woomypc",
                @"axcg wfbnpql ejqb cmnn nncm csvlc wraludb pkmp whtht tfpicer",
                @"moom oomm ommo vfqeii",
                @"xvrgpp rofl yxyrkb oage nypzau pwfnkn jxnhkw cyxsi clzb adwpuh",
                @"mfbz vdtt muzhm wvwwfl ttdv",
                @"cpqgvbu byc pgfrlkr aftl tqm zcqxi juu gnf ppovxh huoa",
                @"konpcp lzordid jqng lwxs nqgj gghkxmf kyn ngqj",
                @"iorhccj xfygc cnfr tysqc xpcyf vmjpitf nut zmrk mgbrtb tcblxwf dkadwrm",
                @"kov jtmp xoatesx qxkilp rmggpfx ltpxzwf vko reqms mqq nps",
                @"hjigmk fyqy wpuwe mwmso thsimfs okcmeyh mzqkez duzaq vzhyrm uyvpkox cwivpls",
                @"ukoerf korufe zhs ntwfz hugem vriyk enfaib hrrcdgf zllsk vkiyr",
                @"shkx khxs wntpjv qdevaw noqyht nwpvjt egh hgok mukdjfi law bzbvjz",
                @"dquk kczxsq tdu trnkjs wqtdc ybvcb",
                @"hlrotxn cumcjkm qwufgle ylm nejh hnje pvaigrx myl sfvsd",
                @"szmvisn aywic vsnimsz iufmybr",
                @"zjozr zojzr qmn ffrggdh wam dafvok",
                @"nxkvlhr posmf posmf posmf zhlzb",
                @"ywis kpqpyb qae zqxpuz pcj hbsfz ejlwa lajew znuom",
                @"qxsl ussivur dstd avojo",
                @"yoeagao egpaqm ymzf kkauy ivm illir wsvchne skmamvn nqxc",
                @"cldo ixzzy vhk nra zhypgab",
                @"qjdd ecxud tbuqq mpotbdk tjdpczn knncm tyy",
                @"rbfc fhhjf innia tsjbbbv fmtcuup rapvhqz ebpzt whdbms gvjoy lykl fquvcby",
                @"bihhfwi lhal udxz uwjwp dmb",
                @"fekxamy uophet yzvv rqj zawlp ldrv mdymkzy taauf",
                @"rcwxvmh edueui ltdyo xfghz dgjig senm ifj",
                @"qcu fii axmgijj ifi oixjfsg jxagijm",
                @"sdtyr rbdh yvnvq czzuig wro",
                @"lot xkto cmpiena nht ozcg aotcw xiegl cyaouj und lsclep cexn",
                @"pgihljk cmgmv sajhi zfvbqij ogwoc ajsih zmppe",
                @"jexwkdp dwpexjk mzjydfu bff rubgdb",
                @"yshfhx emkl hshxyf mkle",
                @"dxgti jdo tkwprv pbxbrqd oiz gsbdphd qotu utfdnq tzvve bqc",
                @"ovdf bshfxyl xspjpd vljdsm mgkd djlsvm mlsjdv",
                @"etyia eytai sfq qafj xzgp ewhsn snwhe lhqp",
                @"zjz mwh dorxm ges gexo rckwsa dltoq mmntha",
                @"hqkuj ypsjcxo dixbe rmvnhjh ovnr",
                @"edc iffaxc lolu xwrvpb gva vti vit",
                @"ceuxq xbwejr lzyvm rozseit cwe mham fivpwj qtv omaktaw",
                @"alzdrk tsxbuld mdbq pgbdtoo xwf vzalric nqe jqwlxsy cbtylu dtubxsl lqm",
                @"rqjmjcs exjpn kpilcgu ihcm lfadjm mlri hpd vqs cxqwqhu twxrtk",
                @"aeuvlcp aubvnw riedvz arypagp uuvg kliehx cokt ogh xsdw cdsyywv",
                @"ddwrgvp bscaq bbfv qrbutp",
                @"jpdg uey eyu uyarl zgbk qyhqq fdvlql zmwkp",
                @"kbt bkt lebhpfu smrzt xalw mmwa zmtzfry tkb",
                @"fcvcv oewfzu fvvcc mldww lwdmw",
                @"ejrltsu sqoyx wfvsdbp bfdspvw bfir jqhgrmt ofdmrjg ysq",
                @"jzwucwn erqjd eikq knpf cvk xvqnscy eei wvfjzmj xujq cqaim boev",
                @"jqhkmr ipjpj zwno ybu krhqjm zqfyyzb dyciy",
                @"ugwsw rpwteje qtvwi pwyhrzt hfcdfmc qbovk ibws",
                @"ffy kdder qjookz bfvmvvq yjzuaj fvxllfb pjyz jcezhye fimyydt qjookz qjookz",
                @"loupd nwsc yytvuqo ltcqxnf",
                @"iho ulvxguz fxbf iqu ofjtmvq xhs ybbusd kxg mebdnah ucttcf zufb",
                @"wzdb wumuhtv kef aavv buu xmjtlur faaccl wospwff bjasr eapfsi",
                @"jau qzszci ciu inagax",
                @"kui tqig fyovsp fvwol fyovsp mzth tcp nhoq",
                @"ajdla wtpj amylu jly tvq wjqef",
                @"ofqc einz bdze tows bdze eew",
                @"avwavzt aesrsjv lbmpi hllv chdbul ezelxn",
                @"imcprs cafb clfg rsjo iylqu nvk vkrq izezlnu vkqr tyhnv",
                @"rwj zboui reh buzio wuhpvid cpzy jrw tsbuiby hmxwqr ute",
                @"ixq luwbi uoiwsjh souz ysoubw uilbw ffwjvw ewzswoh hci zmfdaov whowzse",
                @"xrhgqf xrhgqf giyv giyv",
                @"toiqgzv gakg udgdlb wvi carrn pjyha muqclu",
                @"wuxthi srtszr ourab hpds bakvy fnk yefe yfee doowxcx",
                @"ijdc ujhvls xmy hwg yetsda qelbe nang xgywo wgh",
                @"bhm icq cnam dec enksf qfctz pwxoo bdf cnma xoowp rbls",
                @"jguzh fextz yax kesaunn waljo jltcza tfzxe dezs syi ebwxnks",
                @"flvq bzgd clvqw ahtyvu xbdyv wssxx boscm grgl nqcg",
                @"caskpli hqctxxc nwpyo wjlqfqf ebti dva",
                @"wmsz fzpd ikgeq gti ejftoou ezs cqef mybojc rgwz",
                @"mdaay yfppa pavl fuuvfkh hpod tpb dhxmia emdecm rbqcwbk vecyt",
                @"neha rmvl ndp vlrm dpn debghi vyhvc",
                @"bnp zkxdu iqqkesd abtlx hmjasdq kyvekr krt srrjyd oxmfev oot",
                @"dumlcqd ccm hyir oritdz madjjw",
                @"oakqrs advfmu verrc zkfdcn btndsp",
                @"onlkinl rdtm bscfxre bnu oumyrvv kgc zkj",
                @"tfxfsgm uwmic agswclg uofezgc",
                @"wpfdyjn kjlihk etbot fbu scm gwccce xgownte wig cuaijbo",
                @"bzbdk etozk qracb oftfoo lkooe",
                @"xupzw vmxwu sis wzpxu",
                @"gbz oqbgh jwgrru bzg kwmxcfc jrurgw",
                @"agyjnyc tuec imxlult omwiyjg fiwnoqx nhmnro qtg kbr agyjnyc",
                @"koiq llreotu elrtoul dubfvgy whq",
                @"htm lll crzppb gdjaae nsmxzh gnfvn obiuy ymspzbo iuboy",
                @"thm xlfrr pbxdfo mht tygi sapxgbv mmngzf dej",
                @"eus seu qmstw ues",
                @"yvfsw esut biblze kbjcpk estu xih qzki ezlbbi blzv",
                @"ohq ugc tqqeo jygvpwm vfs ldnfibp ycbpa sml rmime",
                @"kuuow gbg nzwdaf wiimtg lam oqmm",
                @"wsbwkdd hda nqk ticz mvt",
                @"gqbljyh zqugqs cjod sxwlqy qkfs wwvwvt dsojb qbhjlgy riusoa uosari",
                @"jkphfx dbt les jsvoij rnuw mxmmchu dol vto swn",
                @"qqxe vwvephr twdqlyg cvdu xjiych clooq vkwavl whvverp yuz vkwval",
                @"txtbudi tiutdbx wqhx tws utgbf amh hmf izsez ooz",
                @"egdube nhsxjs nxjshs xoy sjsxnh",
                @"egdziod diodegz ejxn zogedid uhhkr rnm cyvvuc uqbl",
                @"rbn pinwag sidwdwv jqdbe jlbemk blkeaqq ipfqbtn zkrbp",
                @"bdryz sbh wxvn mhot wemsfm oemkff",
                @"vxyn xvdwwo xhd vyca zxjaw vfkz xhg ofsphks dyq mmzzd",
                @"yjrqsjf iiesdh envwyx rmtbmiv ggzsg ukx bprfym qmyqc vag ymho hjtoh",
                @"fuxxrd wbweptd vkoffr wbweptd",
                @"gfwcez smetli yjyh pslpz qyokpsm qsy cxjymg wqfkf obuq awz",
                @"eqhm ceest kayf heqm",
                @"rdi dti vntcf ewkmpvf jjwoihc",
                @"sfq qlb xrm ocy vtnj zdznbal zvon stln zwnj wsgalvq vhphap",
                @"pya jay mgnyo pya xmapdn",
                @"hrwbj xhr gvwl ktq ktq gvwl",
                @"rzgqi hjwtthl kxhggbl wepc hgavj ctmqug",
                @"tzfwkc xeqfath iiuwq iiuwq dhwuvy",
                @"gibagy smq getjofc lum msq ulm xuxu bilrus ily",
                @"xlv ndrkch hdcknr nqltoze xvl",
                @"wmc vuzlrj mwc atp cvpx atv ujatz",
                @"hxpafgl ymjltv nvvpy ahycdk jhpdcks ettm lvqyw ertpivm dnezwxx usi kdhcay",
                @"vrh hqyomv mcq ilwjbkz yprjxad",
                @"ugv szfitxg zeluib pfj ijm zmiigxx gltxzz jzljhgh otskue",
                @"mxp bilj jlbi tce yfted zxsqas ftyed",
                @"ykasqv ehye kirmnl upmi dojwmw wzj ykasqv ifixn vreoypz",
                @"kerbgub nnroqk onkqnr gbebkur tjhl knjo ccsem yozvrcg",
                @"ygq evkoj wkn ffljhds scxeibh egsybeg mwvi vgjblj qda ywqpp",
                @"hocvpl ozgkxp xgmj ejzyxm",
                @"gernu kks lxe nxzv sypg xle goz",
                @"xoatis fjp wzlbo dzkonz jtutyj vdonj swro tqclemv xhomap ymeqkua vaxcw",
                @"mxcyjs ywyxndk wng vpftv nsuvu",
                @"jmiyyhh gwser shgcu jmyg cjzegc hmhe eopg kmkan",
                @"smdd dmds mgqhtkh qtamih haqmit skkcy",
                @"dnj rmggy rgymg uburbao rymgg",
                @"klcpjgq ons ajyv sqryt son pjlcgkq xlobdt",
                @"piw shonk tzi mcdumz noskh tebolw yaypn",
                @"ozm mvmjgtg nxj weommiq asnmhzq xjn uobztuo cqgjh utfb oydt ommiewq",
                @"qlwgsc vvpe xgft ahpjc zjtx iyof scwqlg dxgcokx ltrefj xyzq rwto",
                @"ggqdd dqgdg ggdqd kjkmmfp",
                @"htzjam fjbg iagc xls iagc iydtf ihxl boa iydtf",
                @"vhe nqj bwgdoi hhaoa qtulz",
                @"axvyja hpdkwee hnryj prou rgadv oubjdqg knjbc",
                @"caz xibj wqkzwe peioeya vmz hesy ftb",
                @"dudwcr gupj sjrtzc xsqbb hiet nujv bebcvsj eks uuzlcx gex",
                @"kywozi tfzuc mflssw hnxxxqt zzc tzfuc hkokuv mnjg lwkavjp lvpwjak xez",
                @"izgh zfv cingjt dkf cknite qox vfz zvf",
                @"ojpu dzk tehpgnt gntpteh",
                @"glxfxa uxq ajtles ahgzn ajlste zwgc mrpu adz wuunwhc zda",
                @"hdgdtn hnoyz aromkb qujfv yjgmn tbf atw",
                @"uyvsv oaopjv uyvemxk ldpp tthe iisjk txr hebmd yxevukm rkziao znt",
                @"ypdr mnwuzvw acpg kzwz ywbn wcrr umrnlbe lkult ljify azyhu mgqoo",
                @"abmpl omsd xmyl mxyl mgoq kracrf ufm ppwi zpggh",
                @"uxfdpv jnm vvc vchunhl ubv ktj mxolsxz",
                @"fcja eci edzrb nlvksaw lhf ycohh tfztt xso ceub tyv",
                @"rkwtp tcmmvv kufg cxui hdamg suuaej fgku cvjlv",
                @"oldbgy riadoyo djsi wca zxoeq pmemqap aijxa",
                @"nyy ruxcosx xisqoz yny jvzfpbe tlfdiaj ybd jifatdl zuzv",
                @"kxwdz qvrvx svllp ergmme",
                @"swjfuv eronk favcxfm acptbh pnbjn ciqcrlt rgvdnlt icgahb",
                @"ddza xxfn use obqka bfzwjp gmf bld fyvde mxdfdl",
                @"ame bmxbyf ame bmxbyf",
                @"rdgby pyfog dybrg gdryb lpztd",
                @"sntg impd uxgxai naoalb ntnk xgix",
                @"oadpmqj oso criln izih oos",
                @"ouzjq gtl ito xefqt phnv ouzjq hoyjjj",
                @"mlp rboq lpm roqb whvp",
                @"tghcw ggshevw dzsgj ggshevw kec ggshevw",
                @"kmwhb kfcb mbhkw gemz fdh",
                @"euve veue kplrq evue",
                @"hikfiw bcdktj hcnawja gjasvwc vcht igrzly rkxijxe ikfwhi dvmp",
                @"hvksis kafs ktcs sfyqzyt etctrgt vodwr wff tskc juobnm",
                @"dpcsodn ehwc pglywfl yhdp mdiyzx",
                @"ibog umftejh cfm pnxhna wqwx yabnk ygws dqw",
                @"dezz tqw qism rarfe fpmlab xvbau irwtfs wwmoyss yvn xetqp xtqep",
                @"pchqwk npsmd jefec qok uuc ucnpz rlkakn",
                @"kudh rjysb xrdbx bkbmjfo xrdbx",
                @"rogu ssdwsus voa ncw obkxsr",
                @"tflf hlevus scq rrbpat tau wxsq wxoblt",
                @"rzr lex kqdy whtj ffnys xlgkkff msjhy dimaq hrc wyde qkwf",
                @"ghtwd wernjpn tdgwh olrfvmr edq gxvp",
                @"rjirvf skhdgln aauit bipu mubjiwp kowz gyjfbjx cmgdqs",
                @"aftfpbv agajyy aqjll vsf twh robpys lebt eav yribup",
                @"sby ymkla sxkbfwl awmd nhb vlp",
                @"kizvjj ycjswr jkzjiv vuy jijzkv jcs",
                @"cwvch xzqfal tephz lqfzax cnkbdcr mql zflaxq",
                @"jjxzwl himpra ssjf bibfiui seeaq pzse",
                @"jogrn jogrn sqew jogrn oixgwr",
                @"khonpyw iiyxir vybhc ndnxxv kzlt ipmncn",
                @"okqkqu svbemi nfn ovd xgwy edd ujet nrrbv dde vdo",
                @"jobvf dus asvio vaosi sovia",
                @"knmz qbz nkmz zmkn",
                @"isbmopr unduey impobrs hea zswciev sopbmri duuj",
                @"ocs ntgnrdu kbvtzp cvyieu fiyn znmh lhrz ixtnzrj vktbpz lbpqx vzkpbt",
                @"muduhc sabc dlyoisz kuaz ogpyepw yuog ictiiqt",
                @"xjflsf nfklvml thfh uajnmby cichyj xxoqi lpime bxpyx",
                @"riahifn bohbgd obhdgb jni qzvkf ybp hjkkwq ytutd cakcsh smfdoe tuytd",
                @"iddku nccp zgtl yne ppzpqcx lwm",
                @"refpcz uqt uqt uqt",
                @"mtn czxkagb nmt caqacrg bcakxgz",
                @"itxjii uethxbj vpds bsqod diqax inv zrwt doepe",
                @"bfyaj nbvhg zmi buf",
                @"dtre dkwdr nrapm qtfth odvt bbcnae vxuk gqm enlg",
                @"ybt qcfozrk yzrh bfp euuozuz pzsdkxx mhi nbkzprb",
                @"vpuhqn gyx caint antci vfep incat kqdakdx",
                @"ddhi chgnjk ibg xbemitr mjtdph eovw",
                @"ngbtuvq qdttlsg dbqhhwk bkrqze qdttlsg qdttlsg",
                @"evn smvhi dgcmn xjo ascc ahbpj uvzc pwn tung",
                @"ksu thr omg onvsqzz rllakar ysfjtfj grxwyx oawix gpk suk",
                @"qvb iouav yhtndkd vuoia ouaiv",
                @"kud kofcip hcczrgc cvvxxlk rvyamwe duthdzr dftun",
                @"rgv ynw gph tmxwfup nwy",
                @"dnc trawj kwzbx trawj zvp",
                @"ogqxijy tbqtsg tbo vqinnlq jbvgl sfafh rve mcxqs ubh",
                @"qccr lpv puuvdyb tydaflf uxic",
                @"tlon tbfwkxg tlon tlon",
                @"iytiz qjlqaqw uixb lnt zwro uzgxqfi gklgnqs zwgoidw iifk wkwdo",
                @"tmvhxw tmvhxw tmvhxw fhiqpjy ejk kvysd",
                @"cmphg xjjz groiccd dvetuk xbwa zhm lyi ohhd neg bxaw yil",
                @"kdmzopy lxx bvhach goxmxu qbqvzcm qbbrhvb nrfom aixmio grpxz hbrqbbv lkucih",
                @"bnqn phqr uycuxc mopyyfh bbpesqm stgigq stggqi cwtjm asqhpl imvlxj lbmloo",
                @"pws iuvbvjr cwccm qbr srqnstz cjebq",
                @"bfh jobkcy gtbroe lpagq icmax jobyck fbh",
                @"ounqdo qrrr pwi alho rrqr beao rsioepe",
                @"vrccqge qvcgrce cbslkjs qnclw rvmjkw",
                @"aaxjns deupjs wtgxtp penad depbho tbrdt depbho qxg zhjxpgd",
                @"drqfo kbp jfa jaf",
                @"izn oczcitj cpae quvzqo iwwk jck idjdpm",
                @"ecort zgcvxx bvh vrprsf",
                @"fhubfvy ndcfjo kol hyufbfv hvpka",
                @"kpt zgajpc rjvsxa gayznjd",
                @"xeoixk peq kfu lqa mjnv mzvh bicl hlfk",
                @"wyt imdx lksy twy",
                @"xeptp ilxs qbsqzwn rsy slxi xtpep dsdkekl",
                @"rotvbt fuirp elos ciu nhx bxej trmtx ixn xbpc vrxtma",
                @"skcprn yns sao ghlq vftezvc aaryahy telt",
                @"fkaov gexa xijv yiksa xega dhgw okfva gxxs edkecag mqbqvrm nrzcqub",
                @"ljc jujxeof fdj gdzjzr mabbktu pmyrfv uspven zxry snt hrah",
                @"nhujhdr jdhrnuh midm bbavhpp cpjk zmpbasz eptrpou znq zqn",
                @"ywzfq wuu lfflon uuw rke qzwyf hjbms gakx",
                @"yqrq zsk jzn uuuzrml kzs lseupsg waynfh blech",
                @"gwyqej weyjqg uwuje uujwe",
                @"lxud rnwkc bgygkh csq rfvtos ystqp keb gkakodj uthcce eqxifl",
                @"elvj evj rfwo vvgkosh aarcgjs utsbh orwf jxcqvmh uowmktl qtgf",
                @"bqszre oxntty ombwiz mbiwzo",
                @"ccp iilcc tacf czk giwv erqi jgdfah wip xtrzhv wosvbyb",
                @"gymyw rwsxeg gvydr izyk spsonkg knospsg",
                @"djj tbr tbr tbr ice",
                @"yyzh zkykapw puydtik ysxc hjumhsd cuhhw dnnhida yyzh lnklymg",
                @"nhbcxsu ccrbbyw scbxunh ghxrkqh brcwcyb",
                @"latdaav sexa ipzuzjl ayusb etb fshh",
                @"giz akqd vjmabii arfuzgv efrww jxkvolg efrww vrnzgbx",
                @"jmcc vqy adkzj fqrkdo tjrczp ccmj cfponk rptzjc",
                @"jsviu sraw imsj fujm cdf xwqhl lhz ojejzuy trtqblg",
                @"ibz dulm muoq quom etvjzxn tuhrpp jfukac jqctqn qhgbae msgmcit ludm",
                @"zgx bpfa elhp rnyqtq wyceube nkeuxz",
                @"lzxfo vygpecv jszacku zfxlo",
                @"cpmv ysaaj xnp wbvqg hrsiuj venjxna yeqvwmk ftaga dcqxc jgapb rqdixp",
                @"xpbbe tyn hfdlu fto wrgzkou sxylv cqto wdv xqc pnu rapk",
                @"pkrxypl wnu oipq tzbhnc gpug tgzf ofjb",
                @"mvaz bwcv gll itgcye dessw szt gzimgeu bvmohh wbywyhc kzerxbr anjsive",
                @"lhvnrzs qkmjwy pnyciwp mgp jfdz ghvtf yusfzg upab",
                @"xbscukx aubulj snbcmc uscxkbx ddpucyg",
                @"hgv ollh yzpjmpy fcicyae vhg gvh",
                @"prd onyd iux oik xui",
                @"zipadig nvewx cir lbpcusx dljqy",
                @"ifyxzsc btmy lsu tmyb lus ldyzx",
                @"egmyxbe ieasvek dylmj qahtatr uyqgbk",
                @"mejjczw spj vaekp kdud",
                @"vwan mgenld mnlged vpfuil euoxlr rclkpi dfknyoa rhthij kcyxl qaxab crlpik",
                @"pqm eihogk iwml nuauxi ngilkoh jmu mbdi cqxz nblb rmuj zczdgp",
                @"pswbe mtzch wbeps fxtnc psa aioff pas",
                @"prwrpvz oadpqvz tgzrt giom pjyihh rxdir dmya xjolzxv",
                @"khdybe obqkjn kdq jkvmgwo enpat wyw qjbnko waid msest wwkoyts",
                @"yep liv ofmtpod imdd qyw",
                @"afnrx jgn gxarpb myltj ggrsajy mdaobjo vbtn vbtn zlziz eds",
                @"hqr kqu oub skoeqk icnfm cqvld aay bto",
                @"rga odaf exoosh pwevx zpbd plaa xoseoh",
                @"mbr gqu oxvchrt nqa larxmjx pfozej",
                @"ozuo ywubjbg xcua eblwqp nfdvw hmhen zkjfu gmhgp bsyi ktprtf",
                @"src vrysby srybvy znwjm hmypwdl gdmau pqe",
                @"cldr crhi lbaq fbuduyn hygbz uhida",
                @"qrxukq dygkp oaks soka oask",
                @"vpido ajgfq pwlv hezt fmg epwrxo rqvjke iovpd hhkjm",
                @"anxf ydl xnfa hqph olorp",
                @"exydcg onxjm psqlbv ehz boar hze qsblpv",
                @"mnzrvc ipj swg ijp sgw gdkntsd fzz grqwly",
                @"erpq qghpj fay gci uglm afy",
                @"jwbq hbxaub jpdilyt yvalrlk topl qup",
                @"eczonk ftcc paltirb owz tihhe dglxory wthvqcb qdnxm lirejh alyxsr",
                @"ooruaby gboyeu lkv arrz jcqyzl uxlfk fhmeony fcmh",
                @"wzr xjb pwmf okqj adwcedy lkidve uwekxf asbdzr biub",
                @"dikhur pxgh urdinjh wednf ulzdxs",
                @"iplf byt tyt qnnlba pzt bednml ljjtkvo tjovlkj uwms xat",
                @"htzk ltmfha xikeze atfmhl fchxhyz",
                @"lqala bqwgcul vetaa xuxjau zcb wtdmomu wfqmpq sief uyblyz ahv",
                @"aytvvo awm ojaaigg awm dbfaokz",
                @"abq npcyld fzbfku oia qss jkxldm wgtmki pasgxi dieix rpqnuac tecnfy",
                @"nmr qzfj qjfz lsz vnahex",
                @"djxoo jzlkh svy xige",
                @"tjlkkg glcuvmh fwzlhi ecun qlgulj hrfhyql qgdlf ofakqdf zokkvm gelxkq oowgs",
                @"upfpk gfstjlv lxc rjd nhj sbq jpzsz zsjzp",
                @"favd nzqfdid nekfjsf mtjndu",
                @"sgdqx uvpuefv vhwrgd aivav gsqxd jdhfoq",
                @"llaf cthbgy njrpw fqgkx jzf xqkgf lnrfrm gkxqf",
                @"wzdwlc wisst alw kyjeur sjsqfcr tta bijnyn whfyoxl",
                @"dtjr baxkj lmnyrlg nrmyllg",
                @"mtgky xmwf zdko nnocxye gytkm ygp hixk xwmf",
                @"maudjy okgjga uadjmy dzfrk omd",
                @"azz ajdcqkd bcafn zaz dcjaqdk gylyzo",
                @"xzvfbf fopmfxu mvftgr mfupoxf coyhof talcc vpkslo",
            };
            Console.WriteLine("Advent Day 4:");
            Console.WriteLine("The number of valid passphrases is: {0}", advent.Day4(passphrases));
            Console.WriteLine("The number of valid passphrases without anagrams is: {0}", advent.Day4(passphrases, true));
        }
    }
    
    class Advent2017 {
        // Day 1
        // Part 1 Result: 637
        // Part 2 Result: 1060
        public int Day1(string puzzleInput) {
            var sum = 0;
            
            // for part 2, only go around the circle half way, since we're also checking the opposite side
            for (var i = 0; i < puzzleInput.Length / 2; i++) {
                var thisElement = Int32.Parse(puzzleInput[i].ToString());
                // part 1
                //var nextElement = Int32.Parse(i == puzzleInput.Length - 1 ? puzzleInput[0].ToString() : puzzleInput[i + 1].ToString());
                // part 2
                var nextElement = getOppositeElement(i, puzzleInput);
                
                // if elements are same, add that value to sum
                if (thisElement == nextElement) {
                    // part 2, double the element since we're only visiting half of them
                    sum += thisElement * 2;
                }
            }
            
            return sum;
        }
        
        // gets the element on the opposite side of the circle
        int getOppositeElement(int thisIndex, string puzzleInput) {
            var opposite = thisIndex + puzzleInput.Length / 2;
            if (opposite > puzzleInput.Length - 1) {
                opposite -= puzzleInput.Length - 1;
            }
            return Int32.Parse(puzzleInput[opposite].ToString());
        }
        
        // Day 2, Result: 53978
        public int Day2(List<string> puzzleInput) {
            var sum = 0;
            for (var i = 0; i < puzzleInput.Count; i++) {
                sum += getCheckSum(puzzleInput[i]);
            }
            return sum;
        }
        
        // Day 2, Part 2, Result: 314
        public int Day2Part2(List<string> puzzleInput) {
            var sum = 0;
            for (var i = 0; i < puzzleInput.Count; i++) {
                sum += getDivisibleChecksum(puzzleInput[i]);
            }
            return sum;
        }
        
        int getCheckSum(string row) {
            var cells = row.Split(null);
            var min = Int32.MaxValue;
            var max = Int32.MinValue;
            
            for (var i = 0; i < cells.Length; i++) {
                var cell = Int32.Parse(cells[i].Trim());
                
                if (cell < min) {
                    min = cell;
                }
                if (cell > max) {
                    max = cell;
                }
            }
            
            return max - min;
        }
        
        int getDivisibleChecksum(string row) {
            var cells = row.Split(null);
            for (var i = 0; i < cells.Length; i++) {
                var c = Int32.Parse(cells[i].Trim());
                
                for (var j = 0; j < cells.Length; j++) {
                    var d = Int32.Parse(cells[j].Trim());
                    
                    if (i != j && c > d && c % d == 0) {
                        return c / d;
                    }
                }
            }
            
            return 0;
        }
        
        // Day 3, Result: 552
        public int Day3(int start) {
            // each bottom right corner of the spiral is represented by the square of n + 2
            // i.e.: 1^2, 3^2, 5^2 sets each bottom corner at 1, 9 and 25
            // each bottom right corner coordinate increments by 1
            // i.e.: 0,0 1,1 2,2
            // so we need to determine the closest corner, then traverse back to 1^2
            // then work forward to our corner coordinate
            
            var root = Int32.Parse(Math.Floor(Math.Sqrt(start)).ToString()) + 1; // if 23, sqrt is 4.x, so add 1
            
            var diff = 1;
            
            for (var i = root; i > 1; i -= 2) {
                diff++;
            }
            
            var coord = root - diff;
            
            var coords = new int[] {coord, coord};
            
            // now I need to determine the plane I'm on
            // i.e.: 23 is on the lower plane, so is easy to figure out coords (0,2)
            
            var horizontal = true;
            for (var i = (root * root) - 1; i >= start; i--) {
                // starting at 2,2, subtrack 1 from x until we hit mod 0, then subtrack from y
                
                if (horizontal) {
                    coords[0]--;
                }
                else {
                    coords[1]--;
                }
                
                if (i % root == 0) {
                    horizontal = !horizontal;
                }
            }
            
            var steps = Math.Abs(coords[0]) + Math.Abs(coords[1]);
            
            return steps;
        }
        
        // Day 3, Part 2, Result: 
        public int Day3Part2(int puzzleInput) {
            var sum = 1;
            
            // {x, y}
            var coords = new int[] {0, 0};
            var i = 1;
            var n = 1;
            var count = 1;
            var direction = Direction.North;
            var spiral = new Dictionary<string, int>{};
            
            while (sum <= puzzleInput) {
                Console.WriteLine("Adding coord: {0},{1}={2}", coords[0], coords[1], sum);
                //Console.WriteLine("sum: {0}", sum);
                spiral.Add(coords[0].ToString() + "," + coords[1].ToString(), getAdjacentSum(coords, spiral));
                
                Console.WriteLine("n, i, count: {0} {1}", n, i, count);
                
                // move to next cell
                if (n > 1 && i == count) {
                    i = 0;
                    if (direction == Direction.East) {
                        direction = Direction.North;
                    } else {
                        direction++;
                    }
                    Console.WriteLine("setting direction to: {0}", direction);
                }
                // reset at end of square
                
                if (n == count * count) {
                    direction = Direction.North;
                    coords[0]++;
                    count += 2;
                    n = 1;
                    i = 1;
                }
                else {
                    switch (direction) {
                        case Direction.North: {
                            coords[1]++;
                            break;
                        }
                        case Direction.East: {
                            coords[0]++;
                            break;
                        }
                        case Direction.South: {
                            coords[1]--;
                            break;
                        }
                        case Direction.West: {
                            coords[0]--;
                            break;
                        }
                    }
                    
                    n++;
                    i++;
                }
                
                //Console.WriteLine("r, root, direction: {0}, {1}, {2}", r, root, direction);
                //sum += getAdjacentSum(coords, spiral);
                //sum++;
            }
            
            foreach (var item in spiral) {
                Console.WriteLine("key/value: {0}/{1}", item.Key, item.Value);
            }
            
            return getAdjacentSum(coords, spiral);
        }
        
        enum Direction {
            North = 1,
            West = 2,
            South = 3,
            East = 4,
        };
        
        int getAdjacentSum(int[] coords, Dictionary<string, int> spiral) {
            // Console.WriteLine("--Spiral--");
            // foreach (var item in spiral) {
            //     Console.WriteLine("key/value: {0}/{1}", item.Key, item.Value);
            // }
            
            if (coords[0] == 0 && coords[1] == 0) {
                return 1;
            }
            
            var sum = 0;
            for (var x = coords[0] - 1; x < coords[0] + 1; x++) {
                for (var y = coords[1] - 1; y < coords[1] + 1; y++) {
                    var coord = x.ToString() + "," + y.ToString();
                    
                    //Console.WriteLine("Checking coord: {0}", coord);
                    
                    if (coord != coords[0] + "," + coords[1] && spiral.ContainsKey(coord)) {
                        //Console.WriteLine("Found a value at {0}: {1}", coord, spiral[coord]);
                        sum = spiral[coord];
                    }
                }
            }
            return sum;
        }
        
        // Day 4, Result: 451
        // Day 4, Part 2 Result: 223
        public int Day4(List<string> passphrases, bool preventAnagrams = false) {
            var v = 0;
            for (var i = 0; i < passphrases.Count; i++) {
                var passphraseWords = passphrases[i].Split(null);
                
                var valid = true;
                for (var j = 0; j < passphraseWords.Length; j++) {
                    for (var k = 0; k < passphraseWords.Length; k++) {
                        if (j != k && (!preventAnagrams ? passphraseWords[j] == passphraseWords[k] : areAnagrams(passphraseWords[j], passphraseWords[k]))) {
                            valid = false;
                            break;
                        }
                    }
                    if (!valid) {
                        break;
                    }
                }
                
                if (valid) {
                    v++;
                }
            }
            return v;
        }
        
        public bool areAnagrams(string word1, string word2) {
            return String.Concat(word1.OrderBy(c => c)) == String.Concat(word2.OrderBy(c => c));
        }
    }
    
    public class Advent2017Tests {
        List<string> spreadsheet = new List<string> {@"5 1 9 5", @"7 5 3", @"2 4 6 8"};
        
        List<string> spreadsheet2 = new List<string> {@"5 9 2 8", @"9 4 7 3", @"3 8 6 5"};
        
        // List<string> spiral = new List<string> {
        //     @"17 16 15 14 13",
        //     @"18 5 4 3 12",
        //     @"19 6 1 2 11",
        //     @"20 7 8 9 10",
        //     @"21 22 23 24 25",
        // };
        
        [Fact]
        public void Day2ChecksumTest() {
            var advent = new Advent2017();
            Assert.Equal(18, advent.Day2(spreadsheet));
        }
        
        [Fact]
        public void Day2DivisibleChecksumTest() {
            var advent = new Advent2017();
            Assert.Equal(9, advent.Day2Part2(spreadsheet2));
        }
        
        [Fact]
        public void Day3SpiralTest() {
            var advent = new Advent2017();
            Assert.Equal(2, advent.Day3(23));
        }
        
        [Fact (Skip = "I'll revisit this later...")]
        public void Day3SpiralSumTest() {
            var advent = new Advent2017();
            Assert.Equal(11, advent.Day3Part2(10));
        }
        
        List<string> passphrases = new List<string> {
            @"aa bb cc dd ee",
            @"aa bb cc dd aa",
            @"aa bb cc dd aaa",
        };
        
        List<string> passphraseAnagrams = new List<string> {
            @"abcde fghij",
            @"abcde xyz ecdab",
            @"a ab abc abd abf abj",
            @"iiii oiii ooii oooi oooo",
            @"oiii ioii iioi iiio",
        };
        
        [Fact]
        public void Day4Test() {
            var advent = new Advent2017();
            Assert.Equal(2, advent.Day4(passphrases));
        }
        
        [Fact]
        public void Day4AnagramTest() {
            var advent = new Advent2017();
            Assert.Equal(3, advent.Day4(passphraseAnagrams, true));
        }
    }
}
