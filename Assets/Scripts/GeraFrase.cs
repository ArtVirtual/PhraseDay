using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GeraFrase : MonoBehaviour {
	//MOSTRA QUANTIDADE DE FRASE
	string[] frasesMotivation = {
		"Precisamos de pessoas perseverantes diante das dificuldades, que nunca desistam dos seus ideais, que sonhem com um mundo melhor e tenham coragem de lutar por ele. Pessoas menos ego�stas, que estejam preocupadas com a qualidade de vida da pr�xima gera��o.  Daniel Tomaz",
		"Dois homens n�o podem passar meia hora juntos sem que um conquiste uma evidente superioridade em rela��o ao outro.  Samuel Johnson",
		"Tudo o que um sonho precisa para ser realizado � algu�m que acredite que ele possa ser realizado.  Roberto Shinyashiki",
		"Conserve os olhos fixos num ideal sublime, e lute sempre pelo que deseja, pois s� os fracos desistem e s� quem luta � digno de vida.  Desconhecido",
		"A esperan�a n�o ser� a prova de um sentido oculto da Exist�ncia., uma coisa que merece que se lute por ela?  Ernesto S�bato",
		"Acredite em si pr�prio e chegar� um dia em que os outros n�o ter�o outra escolha sen�o acreditar com voc�.  Cynthia Kersey",
		"Se a sua vida for a melhor coisa que j� te aconteceu, acredite, voc� tem mais sorte do que pode imaginar.  Daniel Godri",
		"Acredite em si. Engate a mente na sua boa estrela e reconhe�a que a sua luz interior o conduzir� sempre para cima e para frente.  Desconhecido",
		"Ningu�m � assim t�o velho que n�o acredite que poder� viver por mais um ano.  Marcus C�cero",
		"Quer voc� acredite que consiga fazer uma coisa ou n�o, voc� est� certo.  Henry Ford",
		"Desconfie do destino e acredite em voc�. Gaste mais horas realizando que sonhando, fazendo que planejando, vivendo que esperando... Porque, embora quem quase morre esteja vivo, quem quase vive, j� morreu...  Sarah Westphal",
		"Imagine uma nova hist�ria para sua vida e acredite nela.  Paulo Coelho",
		"Lute com determina��o, abrace a vida com paix�o, perca com classe e ven�a com ousadia, porque o mundo pertence a quem se atreve e a vida � muito para ser insignificante.  Augusto Branco",
		"Gostaria que voc� soubesse que existe dentro de s� uma for�a capaz de mudar sua vida, basta que lute e aguarde um novo amanhecer.  Margaret Thatcher",
		"Acredite que voc� pode, assim voc� j� est� no meio do caminho.  Theodore Roosevelt",
		"Se voc� quer um pedacinho do Para�so, acredite em Deus. Mas se voc� quer conquistar o mundo, acredite em voc� porque Deus j� te deu tudo o que voc� precisa para voc� vencer. Augusto Branco" ,		
		"Acredite, existem pessoas que n�o procuram beleza, mas sim cora��o.  Cazuza",
		"Acredite, vai acontecer qualquer dia, qualquer hora, alguem ir� te enxergar, mesmo que voc� esteja sem maquiagem, suada, desarrumada, descabelada. O famoso homem da sua vida vai te enxergar...Confie em mim, ou em voc�, n�.  Tati Bernardi",
		"Sonhe, Lute, Conquiste, Tudo e possivel, Voc� nasceu para Vencer. Andy Orlando",
		"Lute e empurre fortemente para o que voc� acredita, voc� ficar� surpreso, voc� � muito mais forte do que pensa.  Lady Gaga",
		"Tenta alcan�ar o que julgas ser imposs�vel,lute por tudo que queres, aceite o desafio do destino e busca entre as dificuldades o maior tesouro que a vida tem de melhor! O AMOR Assun�ao Anacleto R. Lopes",
		"Por mais que tente, por mais que lute, n�o consigo esconder os meus sentimentos. A dor que me percorre a alma � uma luta desigual com a palavra que um dia algu�m inventou e chamou de AMOR.  Ricardo Baskaville Berenguer",
		"Se um dia a raz�o te pedir para desistir e o cora��o te mandar lutar, lute pois n�o � a raz�o que bate pra voc� viver e sim o cora��o.  Cello Menezes",
		"N�o seja melhor que ningu�m, seja apenas diferente e lute pelos seus objetivos.  Ananda de Almeida Fonseca",
		"Sonhe, apesar das ilus�es. Caminhe, apesar dos obst�culos. Lute, apesar das barreiras e, acima de tudo, acredite em voc� mesmo.",
		"Se o inimigo for mais forte que voc�, fuja! Se ele te alcan�ar, lute! Se ele vencer, n�o se sinta culpada! Levante-se e esconda-o, onde jamais possa ser encontrado!  Gina",
		"Lute mesmo que ainda parecendo derrotado.  Luciano Junior",
		"Acredite no seu sonho, lute por ele, e quando tiver a oportunidade aproveite como se fosse um momento �nico em sua vida, e acredite ele pode n�o ser �nico, mas vai ser inesquec�vel.  Heitor Levinski",
		"Vit�ria, Se estiver sem for�as, lute, Se estiver sem f�, acredite! Se todos estiverem rindo de voc�, supere-se Se seus inimigos est�o vencendo, surpreenda Se estiver com medo, enfrente S� vencemos o que enfrentamos! Vitor Rafael",
		"Lute mesmo sem for�as. Acredite mesmo sem esperan�as.  Aline Aparecida Rocha",
		"Lute por aquilo que voc� acredite, n�o espere! A �nica pessoa que pode fazer a vida valer a pena � voc� mesma! Aprenda a se desafiar�  Bellah Menina",
		"Lute diante das coisas mais dif�ceis da sua vida...para que um dia possa olhar para tr�s e dizer: -Foi dif�cil..Mas eu consegui!!!.  Desconhecido",
		"Ame, acredite, pense, grite, sonhe, conquiste, lute, batalhe, tenha for�a, tenha foco, tenha f�. Sorria e agrade�a a Deus por mais um dia. Bruna Martins",
		"Tudo na vida acontece em fun��o do melhor!Acredite, a sua amargura de hoje �, com certeza, a sementinha da sua alegria de amanh�!.  Mariluci Carvalho de Souza",
		"A primavera chegar�, mesmo que ningu�m mais saiba seu nome, nem acredite no calend�rio, nem possua jardim para receb�-la.  Cec�lia Meireles",
		"N�o acredite mais em pessoas especiais, mas em momentos especiais com pessoas habituais.  Chafic Jbeili",
		"Acredite em milagres, mas n�o dependa deles.  Emanuel Kant",
		"Nada � por acaso...Acredite em seus sonhos e nos seus pontenciais....Na vida tudo se supera...   Mema velame",
		"Acredite no seu potencial, procure motivar-se todos os dias, mantenha sua auto-estima sempre elevada, voc� realizar� grandes feitos em sua vida.  Eduardo Frederico",
		"Acredite em si mesmo, pois at� sua sombra te abandona no escuro.  Mr. Catra",
		"Chame o sucesso para fazer parte de sua vida. Acredite no seu potencial criador, seja inovador, treine sua mente para vencer, estipule metas e, principalmente, lute por seus ideais. Fl�vio Souza",
		"Acredite em voc� mesmo,pois � s� voce que pode se alto julgar.Ouse,arrisque e nunca se arrependa. N�o desista jamais e saiba valorizar quem te ama, esses sim merecem seu respeito.Quanto ao resto, bom, ninguem nunca precisou de restos para ser feliz! Desconhecido",
		"Pedir aos outros que acreditem em nos � facil, o dificil mesmo � quando os outros pedem que acreditemos neles, por isso partilha a confian�a porque sem confia�a a rela��o n�o resiste e o amor n�o existe.Eugenio Leandro Pascoal Salvador",
		"Fa�a sua hist�ria, acredite nela, tenha f� e coragem para fazer de seus sonhos a realidade, busque o pr�ximo, pois os sonhos e as hist�rias precisam de uma eternidade de seres para deixarmos real.  Alexandra Guiso",
		"A vida apesar de dura � m�gica, por isso sempre acredite no inesperado. Maria Miranda",
		"N�o acredite em nada que venha f�cil demais. Sempre temos que lutar pelo que realmente queremos. Estamos em constante prova��o.  Daniela Lage",
		"Busque sempre fazer as coisas com alegria, mesmo que sejam dificeis, d� o maximo de si, e acredite, isso muda o futuro.  Allan Rocha",
		"N�o acredite em todo mundo que sorrir pra vc!  Carine",
		"Jamais sofra antecipadamente. Pense positivo. Acredite nos seus sonhos. Nunca desista de lutar. A vida � generosa para aqueles que acreditam nela.  Vitoria Cirilo",
		"Imagine uma hist�ria, acredite nela, fa�a acontecer e se prontifique a viver.	Daiane Rabelo",
		"Acredite, como tudo na vida acontece por uma quest�o de h�bito, com a tristeza n�o � diferente, se insistires em cultu�-la, estar�s escancarando as portas para ela.  Ivan Teorilang",
		"Acredite, voc� tem for�as para chegar onde quiser. Mas nao basta querer tem que fazer!. Thiago Garcia",
		"Para que tudo d� certo em um relacionamento, acredite... Mesmo que voc�s sejam diferentes... Quando h� AMOR se tornam iguais... Rubao",
		"Acredite naquilo que vem de dentro, que real se tornar�s. Samantha Raube",
		"Se voc� tem o poder de mentir, acredite, eu tenho a magia de fingir acreditar!  Matheus Arruda Pinheiro",
		"Voc� tem todo o direito de n�o acreditar em todas as pessoas, mas tem o dever de acreditar em si mesmo.  Thiago Garcia",
		"Jamais deposite sua felicicidade nos outros, deposite em si mesmo. pois n�o ha segun�a maior.  Thiago Garcia",
		"N�o acredite no rosto das pessoas, a maldade est� sempre na mente. Thiago Garcia",
		"Ela era a roubadora de livros que n�o tinha palavras. Mas, acredite, as palavras estavam a caminho e, quando chegassem, Liesel as seguraria nas m�os feito nuvens, e as torceria feito chuva. Markus Zusak - A Menina que Roubava Livros",
		"Esse mundo � seu, fa�a dele o que quiser. N�o deixe que lhes prescrevam verdades absolutas. Acredite no que quiser e acredite piamente. E se preciso, mude de opini�o.  Fred S� Teles",
		"N�o acredite no medo. N�o tenha d�vidas.Seja determinada.Fa�a algo pela sua felicidade.Agora,  Edson Rufo",
		"Nada � tudo est�!...  Thiago Garcia",
		//"Caminhe sempre e em todos os momentos de sua vida com coragem e dignidade, pois acredite, n�o existe atalhos, supere e simplesmente acredite... Perceba que algo bom atrai algo de bom... O sorriso no olhar... Nosso sorriso sem parar... Simplesmente querer... Querer e crer que tudo vai se eternizar...a alegeria se realizar�...e os encantos se firmar! Marcelo Labonia",
		"F�, duas letras que podem mudar sua vida, acredite. (Peter Pan) Walt Disney",
		"Quer conquistar algo? Conquiste calos nas m�os e esfole os joelhos. Cris Westphal",
		"Treine suas habilidades e aptid�es, seja um competidor forte, e conquiste seu trof�u.� Latumia (W.J.F.)Latumia.",
		"Aconte�a o que acontecer, seja sempre voc�. Lute pelos seus ideais. Corra atr�s do seus desejos e realize-os. Ver�s que o trof�u da sua vit�ria � o resultado da sua conquista. Cl�udio M. Assun��o",
		"Transforme o trabalho em prazer.E seja um vagabundo feliz e produtivo.E lute para que ninguem te transforme num trabalhador triste e improdutivo.Moacir Soledade",
		"N�o importa a dificuldade de lutar. Lute! Procure for�as, sinta-se forte, n�o importa o tempo que dura sua luta, fa�a sua parte. Lute sabendo que no final a vit�ria sempre vem e quanto maior for a luta, maior ser� a sua vit�ria. Ana Meira",
		"Lute para ser UM SER HUMANO MELHOR, e n�o para ser O MELHOR DOS SERES HUMANOS. Cirio Fernandes",
		"Lute por seu ideal,seja voc� mesmo,esque�a os outros.  Rodolfo.",
		"A lagrima de hoje pode ser o sucesso do amanha,lute,espere, e alcan�arar. Camila Lima",
		"Acredite, somente na verdade que te constroi.  Edson Rufo",
		"N�o acredite em tudo que te dizem... tente descobrir por si mesmo a verdade... JeZieL L. CarVAlhO",
		"Acredite no amor, acredite na magia. Acredite em si mesmo. Acredite nos seus sonhos. Se voc� n�o o fizer, quem o far�? Jon Bon Jovi",
		"Acredite que voc� � capaz de fazer qualquer coisa, e voc� ir� longe. Nunca diga que nada � imposs�vel, porque quem diz que � imposs�vel, nunca tentou. Ent�o tente, e se n�o conseguir, diga que pelo menos voc� atreveu a tentar e nunca poder� ser chamado de covarde. Cintia Nogueira",
		"N�o duvide das suas intui��es. Acredite no que o esp�rito est� transmitindo.	Zibia",
		"Viva a vida, n�o deixe ela simplesmente acontecer, acredite em suas escolhas, acredite em suas conseq��ncias. Thais S.G",
		"Todos desanimamos em certo ponto, mas acredite que o melhor esta por vir. Eve Frozino",
		"Acredite na vida, isso sim vale.  Edson Rufo"};
	//VARIAVEL FRASE DO TIPO PUBLICA PERMITINDO EXPAN�AO DO ARQUIVO
	public string frase = "";
	Text text;	

	//PEGA OS VALORES DA VARIALVE TEXT E JOGA EM Text
	void Awake () {
		text = GetComponent <Text> ();
	}
	void Update () {
	}
	//FUN�AO START ESTA COMO PUBLICA PARRA SER ENCONTRADA NO EVENDO BUTTON
	public void Start () {
		//VERIFICA O TAMANHO DO VETOR E CAPTURA A QUANTIDADE DE FRASES E JOGA EM (quantFrases)
		int quantFrases = frasesMotivation.Length;

		//FAZ O SORTEIRO DE 0 A quantFrases e JOGA A POSI�AO SORTEADA EM NFRASES
		int nposition = UnityEngine.Random.Range(0, quantFrases);
		frase = frasesMotivation [nposition];
		text.text = frase;
		Debug.Log ("QUANTIDADE DE FRASES = "+quantFrases);
		Debug.Log ("FRASE ESCOLHIDA" + nposition);
	}
}
