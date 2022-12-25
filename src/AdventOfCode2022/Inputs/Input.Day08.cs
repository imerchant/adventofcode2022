namespace AdventOfCode2022.Inputs;

public static partial class Input
{
    public const string Day08 =
@"301220120123412411222431204050154502352345215611331265331250145342122214525502214010044420343123123
212320323343022012341342154350405334001503310300211115153234405042152322215224432102400231113311111
201121301211224101311542432232543306541420361630235333011410624063304221040115102553044222124011231
232202332000223341510415415041456543552366532665005356434300206166046103153010034420344343011033113
210314434121343443320133105330346640420462134535200335545300063363254665242325230054401312222330003
230214144101224050540112215100230300363531055535606540515103053341534215435154012112140240124100110
231101440201215435252051416446206332423151420012651331143355655244262555053300034015013244122130030
214222212324200401052120065613545410604234254167572224245015316613164134265153313214432220442033121
010101140402334554220203222036634231512152221455263551635633346541265223541540132045335333002223424
141224023202512320500606623246021536434116717372527356442422357712253035560552010313145410243214244
342313244142203024440112330041036065142245413435573537671475271244610245022435212200405455551031300
400412431024553054563062232450106636227551743332536773246216563237746040260223025405240105550211342
141411114240054115626641115664417124644446553167127275573572277534716362414652422624302412000344204
304244002433112544632613515265757653216235741254644271315654143447247446415244144112322551315312440
034412130253154014325430531636135646423361675474554354114661252723134131331331364550211025331005110
203230120341502446443342636426563227647672423846477226654522546745461257167105415103340235011202102
000304220335434256006236536157317262616265763646677874377378263627235146376615515544066624323231543
101323340335206434552203561646466267426825854776848224328252384531177377727463300325223111432452044
443203522336150155435544744243555565545237722358736446652663532873525636261412225525550006103302105
024402111202046625261447262172117482763754324238438534828367456666385662441762475663425231012052231
304102502005006215165124145477583756557534848357388484458683773276743654452221742726125603631535221
102242345301310562362655166723276388782224434488345643223328875357434577377774571124062514515225323
243240452045506406233373246572828585355877339635749687859248246824648243733613635453456402505250303
012352100012020202464336343645745643432459668843833863555554453734885388527435724644214236030032234
502301551613053433631262457468258867289345397685878634954795338424484872426226353756723364155214515
423041536552451365166244244533646822743993898794997445777675763398844356245712374176524561556305525
425254640333051274352217364867636553657469538835745385349436985448743264485283366446114460665235412
451305136116044364536433362258776588858395555558784748933645435747556548238346672563734344020454302
432303643553065262322344228232565576689647769594849965393545794453967722354542675575263552410143115
134544203161553255673562273655895763938858688958546785546995776997839965834382885435545631503335420
555120002034333741674266784562695566888447446849894657668489395353895595526886884344327466141516541
513443021302125256763465382844658763845358758869688948575985943473999357685734374175371446220146233
233366010551721127328385236556377437634587845849877758459689687794745477428788742731316465140405213
553011226633221264468324542499436483854879476698495899976485685488773948962325655755266442362003543
312310355415566137337775829643373677544476849477957567497649568966978435833576736386411214630355151
553145403544542737764542375578459459765676558566476444687477445946459378969263463861117325515431032
536600400372417274463258586446436786877854445766879776549484448887448579549836737426771156120411052
030621320724121554684336878497569899885854988855858555775456559646495997979468273647347456245100543
545015312153425765287374339999948784855487886865776557656565676778594554989747852238614427623334041
203005461166615125245248633779856478585597855957589689986888656699549686966355478473725534436206000
552104352652311173347625849374448596777558588767888585799589875757945995549567776384722373626201524
103604131421156167438445367445944478744687879597557966758786897455674875666365253527343435256603601
300251364451465528673586486838569558457965667868668568797565799949548765587445748556373652351606135
203613231642774436372333986973765865968569869659668887695588756978695547464449478577546236167206025
000526564661714825335338489687486957856857855999788768958878987799494866538374633368677562673506424
515644525376577475566446984796979687487766955689666777875898796699874589553539884845683175752360631
221333616257462253823256375979645755896686997869696867698969958844999687686476364354576477345551111
105222627452134822874253968777797786579655789896697888689986866976775779378896326264363317162751623
162663173774176522666878887636864568989556887778997867979686869994994668955878548843786742723736203
532212411613465674686254989747549989687685879666668989986756655657544797785388372436622767147424660
061430341565238668884894448998884968886585676968898898887797795594859978795536965546586321556760355
204541545567555653452864338665675969797686696989669999697778587687445456986538478322446257552365541
655210032533533474674648398796577485555756797879766896878759679897748887646963922274775445666332035
053321357461466882342436934979474474786699989987686798866969688869574558588835762723624774536431166
425041634561312425882487676489694958795969757677677787687667668745846895668784782733254653163100605
344310214433422228424464935784566975876698858796887769889968969647689677947447477245223663363264353
012103166457117866567539896646478766886868755577978876887556878875797456794886958725574112516550415
413644241335211836757687384748875888457579756795867975569679769875958466759557667477876467665436364
162433152223317868882246466489998974769885556787595776775676788845855763393365742834482216655401026
500614243747242223556575388534395464699869895767665788787956594678957798795886862225721534637646212
242634342176667133277463595457877478984767787799769898889775888858895875758637368336261313356414300
223205560227474377478554997966367944497877689866899558856977656965547586747685382327221347441146226
322455466216143484536844779897496757954488957957898966886586675678888653535576477832464231615155324
242335461373333262738285294874587649485768768756859998965778556857697358467855263664166411126122653
442153320312725352645222487595939346478865868447588576959689664564667987947863564283733267742015623
314256435256635233868576887878636755678944665464484575684575697584575336547784452783535121441266154
223210513276524633887828464489635943745697744976674678945746697677399465735288783524413443155052460
414644344437711641625883235659985578977459597858484566679475486473855973896455735345552521314243015
303253565166734271425285323787763975858945897789759985997698796347779944885385552472565572215360642
554345026245552362643534848687345838937664445457956798786577433576566547626774284415241562551163504
311535565216661455148884287865768434966933844685584479978489494757874552577566854667712125345561545
415250611366327134655472756753545737584664446946696869669867693575365348285472261146676153654423343
245134635554051122723564642433875435935979656663668837797668649877868784674366711177437413214613242
550305433351016326452653747274646969964344344955633437473798845985852738832263655166223231013250350
412424612302616576262646757668355434555989468964573354645759674644744382678666232347542030341661053
242250452046136264165613485835446658933483399657658764964566438484376638324734716771116242431415343
215351034333540431527612622887846533476959369569746679337488463558585763464275533366551552100042055
435431152542541137277441543722662552265876998963863345653536848472468446825623116641634431511341415
512310146424650645726632222733373758536677539594973344357244627586436388227315222723436261011354444
415342343465665344577661441528646685383427283566766246753572785343237264536223626355350051400140114
241050242115325145031526345615255855442353746482385388835847843772354575412177127416310323254520420
020220124435411053633257436463635336832525634734264453487345354485334651724244114546332526244014343
233144204333151340325721264561431226263673564625645257644453365842865136737725510345534241014450104
214445105522101254615065716656473235246624687543865265286684547535626265545173540645424255433043332
131141005503150612140634466735217613138345322342853334247734784516716553114671206254014513103241500
120132523034235121510330646154142646314331362452535865757484632521317751341716362446121030453315304
222332342104255141541516053742767376342422671752664587373155226235757465552063266050454310555023234
130022331402524533534126360254271165656147565354323324127344143267561232655640150546201542425232423
041244331331204304551224525323327646371114744734661445454712776141442460245244062010323033300223040
314114011311133543043561246666161424252355464267753775116255217554737010132161163160333313105310431
241411310012501313224133414363533552666555416611756217364167127132203511115524044001111200411313443
214302012402443103350331642331524446633763473467453377136566732405003511614151100044055214231314311
010202242015444310420164245052526156300412151526245266534126364115514456545426434302254122342301411
011423214303322230335200221004343440314264121472144246346134341155334411654112313203311044301330344
301224314420311045034445523602316023152013003056146213152100641500545520504415031222210033304041411
220214142234023331303304444234306015540260423514533053233166213614214141332141350123320443304043021
012034313114122310325254321150626562505200402655111220563433533535445241355033442330140121212324203
132300421231302002541021054032536231430015654305433356436004156146330254151224453535144411201021112
011201113143220302144232532235500205436316601263264003140631445266055502252414045114101420043032302";
}