using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GeraFrase : MonoBehaviour {
	//MOSTRA QUANTIDADE DE FRASE
	string[] frasesMotivation = {
		"Precisamos de pessoas perseverantes diante das dificuldades, que nunca desistam dos seus ideais, que sonhem com um mundo melhor e tenham coragem de lutar por ele. Pessoas menos egoístas, que estejam preocupadas com a qualidade de vida da próxima geração.  Daniel Tomaz",
		"Dois homens não podem passar meia hora juntos sem que um conquiste uma evidente superioridade em relação ao outro.  Samuel Johnson",
		"Tudo o que um sonho precisa para ser realizado é alguém que acredite que ele possa ser realizado.  Roberto Shinyashiki",
		"Conserve os olhos fixos num ideal sublime, e lute sempre pelo que deseja, pois só os fracos desistem e só quem luta é digno de vida.  Desconhecido",
		"A esperança não será a prova de um sentido oculto da Existência., uma coisa que merece que se lute por ela?  Ernesto Sábato",
		"Acredite em si próprio e chegará um dia em que os outros não terão outra escolha senão acreditar com você.  Cynthia Kersey",
		"Se a sua vida for a melhor coisa que já te aconteceu, acredite, você tem mais sorte do que pode imaginar.  Daniel Godri",
		"Acredite em si. Engate a mente na sua boa estrela e reconheça que a sua luz interior o conduzirá sempre para cima e para frente.  Desconhecido",
		"Ninguém é assim tão velho que não acredite que poderá viver por mais um ano.  Marcus Cícero",
		"Quer você acredite que consiga fazer uma coisa ou não, você está certo.  Henry Ford",
		"Desconfie do destino e acredite em você. Gaste mais horas realizando que sonhando, fazendo que planejando, vivendo que esperando... Porque, embora quem quase morre esteja vivo, quem quase vive, já morreu...  Sarah Westphal",
		"Imagine uma nova história para sua vida e acredite nela.  Paulo Coelho",
		"Lute com determinação, abrace a vida com paixão, perca com classe e vença com ousadia, porque o mundo pertence a quem se atreve e a vida é muito para ser insignificante.  Augusto Branco",
		"Gostaria que você soubesse que existe dentro de sí uma força capaz de mudar sua vida, basta que lute e aguarde um novo amanhecer.  Margaret Thatcher",
		"Acredite que você pode, assim você já está no meio do caminho.  Theodore Roosevelt",
		"Se você quer um pedacinho do Paraíso, acredite em Deus. Mas se você quer conquistar o mundo, acredite em você porque Deus já te deu tudo o que você precisa para você vencer. Augusto Branco" ,		
		"Acredite, existem pessoas que não procuram beleza, mas sim coração.  Cazuza",
		"Acredite, vai acontecer qualquer dia, qualquer hora, alguem irá te enxergar, mesmo que você esteja sem maquiagem, suada, desarrumada, descabelada. O famoso homem da sua vida vai te enxergar...Confie em mim, ou em você, né.  Tati Bernardi",
		"Sonhe, Lute, Conquiste, Tudo e possivel, Você nasceu para Vencer. Andy Orlando",
		"Lute e empurre fortemente para o que você acredita, você ficará surpreso, você é muito mais forte do que pensa.  Lady Gaga",
		"Tenta alcançar o que julgas ser impossível,lute por tudo que queres, aceite o desafio do destino e busca entre as dificuldades o maior tesouro que a vida tem de melhor! O AMOR Assunçao Anacleto R. Lopes",
		"Por mais que tente, por mais que lute, não consigo esconder os meus sentimentos. A dor que me percorre a alma é uma luta desigual com a palavra que um dia alguém inventou e chamou de AMOR.  Ricardo Baskaville Berenguer",
		"Se um dia a razão te pedir para desistir e o coração te mandar lutar, lute pois não é a razão que bate pra você viver e sim o coração.  Cello Menezes",
		"Não seja melhor que ninguém, seja apenas diferente e lute pelos seus objetivos.  Ananda de Almeida Fonseca",
		"Sonhe, apesar das ilusões. Caminhe, apesar dos obstáculos. Lute, apesar das barreiras e, acima de tudo, acredite em você mesmo.",
		"Se o inimigo for mais forte que você, fuja! Se ele te alcançar, lute! Se ele vencer, não se sinta culpada! Levante-se e esconda-o, onde jamais possa ser encontrado!  Gina",
		"Lute mesmo que ainda parecendo derrotado.  Luciano Junior",
		"Acredite no seu sonho, lute por ele, e quando tiver a oportunidade aproveite como se fosse um momento único em sua vida, e acredite ele pode não ser único, mas vai ser inesquecível.  Heitor Levinski",
		"Vitória, Se estiver sem forças, lute, Se estiver sem fé, acredite! Se todos estiverem rindo de você, supere-se Se seus inimigos estão vencendo, surpreenda Se estiver com medo, enfrente Só vencemos o que enfrentamos! Vitor Rafael",
		"Lute mesmo sem forças. Acredite mesmo sem esperanças.  Aline Aparecida Rocha",
		"Lute por aquilo que você acredite, não espere! A única pessoa que pode fazer a vida valer a pena é você mesma! Aprenda a se desafiar…  Bellah Menina",
		"Lute diante das coisas mais difíceis da sua vida...para que um dia possa olhar para trás e dizer: -Foi difícil..Mas eu consegui!!!.  Desconhecido",
		"Ame, acredite, pense, grite, sonhe, conquiste, lute, batalhe, tenha força, tenha foco, tenha fé. Sorria e agradeça a Deus por mais um dia. Bruna Martins",
		"Tudo na vida acontece em função do melhor!Acredite, a sua amargura de hoje é, com certeza, a sementinha da sua alegria de amanhã!.  Mariluci Carvalho de Souza",
		"A primavera chegará, mesmo que ninguém mais saiba seu nome, nem acredite no calendário, nem possua jardim para recebê-la.  Cecília Meireles",
		"Não acredite mais em pessoas especiais, mas em momentos especiais com pessoas habituais.  Chafic Jbeili",
		"Acredite em milagres, mas não dependa deles.  Emanuel Kant",
		"Nada é por acaso...Acredite em seus sonhos e nos seus pontenciais....Na vida tudo se supera...   Mema velame",
		"Acredite no seu potencial, procure motivar-se todos os dias, mantenha sua auto-estima sempre elevada, você realizará grandes feitos em sua vida.  Eduardo Frederico",
		"Acredite em si mesmo, pois até sua sombra te abandona no escuro.  Mr. Catra",
		"Chame o sucesso para fazer parte de sua vida. Acredite no seu potencial criador, seja inovador, treine sua mente para vencer, estipule metas e, principalmente, lute por seus ideais. Flávio Souza",
		"Acredite em você mesmo,pois é só voce que pode se alto julgar.Ouse,arrisque e nunca se arrependa. Não desista jamais e saiba valorizar quem te ama, esses sim merecem seu respeito.Quanto ao resto, bom, ninguem nunca precisou de restos para ser feliz! Desconhecido",
		"Pedir aos outros que acreditem em nos é facil, o dificil mesmo é quando os outros pedem que acreditemos neles, por isso partilha a confiança porque sem confiaça a relação não resiste e o amor não existe.Eugenio Leandro Pascoal Salvador",
		"Faça sua história, acredite nela, tenha fé e coragem para fazer de seus sonhos a realidade, busque o próximo, pois os sonhos e as histórias precisam de uma eternidade de seres para deixarmos real.  Alexandra Guiso",
		"A vida apesar de dura é mágica, por isso sempre acredite no inesperado. Maria Miranda",
		"Não acredite em nada que venha fácil demais. Sempre temos que lutar pelo que realmente queremos. Estamos em constante provação.  Daniela Lage",
		"Busque sempre fazer as coisas com alegria, mesmo que sejam dificeis, dê o maximo de si, e acredite, isso muda o futuro.  Allan Rocha",
		"Não acredite em todo mundo que sorrir pra vc!  Carine",
		"Jamais sofra antecipadamente. Pense positivo. Acredite nos seus sonhos. Nunca desista de lutar. A vida é generosa para aqueles que acreditam nela.  Vitoria Cirilo",
		"Imagine uma história, acredite nela, faça acontecer e se prontifique a viver.	Daiane Rabelo",
		"Acredite, como tudo na vida acontece por uma questão de hábito, com a tristeza não é diferente, se insistires em cultuá-la, estarás escancarando as portas para ela.  Ivan Teorilang",
		"Acredite, você tem forças para chegar onde quiser. Mas nao basta querer tem que fazer!. Thiago Garcia",
		"Para que tudo dê certo em um relacionamento, acredite... Mesmo que vocês sejam diferentes... Quando há AMOR se tornam iguais... Rubao",
		"Acredite naquilo que vem de dentro, que real se tornarás. Samantha Raube",
		"Se você tem o poder de mentir, acredite, eu tenho a magia de fingir acreditar!  Matheus Arruda Pinheiro",
		"Você tem todo o direito de não acreditar em todas as pessoas, mas tem o dever de acreditar em si mesmo.  Thiago Garcia",
		"Jamais deposite sua felicicidade nos outros, deposite em si mesmo. pois não ha segunça maior.  Thiago Garcia",
		"Não acredite no rosto das pessoas, a maldade está sempre na mente. Thiago Garcia",
		"Ela era a roubadora de livros que não tinha palavras. Mas, acredite, as palavras estavam a caminho e, quando chegassem, Liesel as seguraria nas mãos feito nuvens, e as torceria feito chuva. Markus Zusak - A Menina que Roubava Livros",
		"Esse mundo é seu, faça dele o que quiser. Não deixe que lhes prescrevam verdades absolutas. Acredite no que quiser e acredite piamente. E se preciso, mude de opinião.  Fred Sá Teles",
		"Não acredite no medo. Não tenha dúvidas.Seja determinada.Faça algo pela sua felicidade.Agora,  Edson Rufo",
		"Nada é tudo está!...  Thiago Garcia",
		//"Caminhe sempre e em todos os momentos de sua vida com coragem e dignidade, pois acredite, não existe atalhos, supere e simplesmente acredite... Perceba que algo bom atrai algo de bom... O sorriso no olhar... Nosso sorriso sem parar... Simplesmente querer... Querer e crer que tudo vai se eternizar...a alegeria se realizará...e os encantos se firmar! Marcelo Labonia",
		"Fé, duas letras que podem mudar sua vida, acredite. (Peter Pan) Walt Disney",
		"Quer conquistar algo? Conquiste calos nas mãos e esfole os joelhos. Cris Westphal",
		"Treine suas habilidades e aptidões, seja um competidor forte, e conquiste seu troféu.” Latumia (W.J.F.)Latumia.",
		"Aconteça o que acontecer, seja sempre você. Lute pelos seus ideais. Corra atrás do seus desejos e realize-os. Verás que o troféu da sua vitória é o resultado da sua conquista. Cláudio M. Assunção",
		"Transforme o trabalho em prazer.E seja um vagabundo feliz e produtivo.E lute para que ninguem te transforme num trabalhador triste e improdutivo.Moacir Soledade",
		"Não importa a dificuldade de lutar. Lute! Procure forças, sinta-se forte, não importa o tempo que dura sua luta, faça sua parte. Lute sabendo que no final a vitória sempre vem e quanto maior for a luta, maior será a sua vitória. Ana Meira",
		"Lute para ser UM SER HUMANO MELHOR, e não para ser O MELHOR DOS SERES HUMANOS. Cirio Fernandes",
		"Lute por seu ideal,seja você mesmo,esqueça os outros.  Rodolfo.",
		"A lagrima de hoje pode ser o sucesso do amanha,lute,espere, e alcançarar. Camila Lima",
		"Acredite, somente na verdade que te constroi.  Edson Rufo",
		"Não acredite em tudo que te dizem... tente descobrir por si mesmo a verdade... JeZieL L. CarVAlhO",
		"Acredite no amor, acredite na magia. Acredite em si mesmo. Acredite nos seus sonhos. Se você não o fizer, quem o fará? Jon Bon Jovi",
		"Acredite que você é capaz de fazer qualquer coisa, e você irá longe. Nunca diga que nada é impossível, porque quem diz que é impossível, nunca tentou. Então tente, e se não conseguir, diga que pelo menos você atreveu a tentar e nunca poderá ser chamado de covarde. Cintia Nogueira",
		"Não duvide das suas intuições. Acredite no que o espírito está transmitindo.	Zibia",
		"Viva a vida, não deixe ela simplesmente acontecer, acredite em suas escolhas, acredite em suas conseqüências. Thais S.G",
		"Todos desanimamos em certo ponto, mas acredite que o melhor esta por vir. Eve Frozino",
		"Acredite na vida, isso sim vale.  Edson Rufo"};
	//VARIAVEL FRASE DO TIPO PUBLICA PERMITINDO EXPANÇAO DO ARQUIVO
	public string frase = "";
	Text text;	

	//PEGA OS VALORES DA VARIALVE TEXT E JOGA EM Text
	void Awake () {
		text = GetComponent <Text> ();
	}
	void Update () {
	}
	//FUNÇAO START ESTA COMO PUBLICA PARRA SER ENCONTRADA NO EVENDO BUTTON
	public void Start () {
		//VERIFICA O TAMANHO DO VETOR E CAPTURA A QUANTIDADE DE FRASES E JOGA EM (quantFrases)
		int quantFrases = frasesMotivation.Length;

		//FAZ O SORTEIRO DE 0 A quantFrases e JOGA A POSIÇAO SORTEADA EM NFRASES
		int nposition = UnityEngine.Random.Range(0, quantFrases);
		frase = frasesMotivation [nposition];
		text.text = frase;
		Debug.Log ("QUANTIDADE DE FRASES = "+quantFrases);
		Debug.Log ("FRASE ESCOLHIDA" + nposition);
	}
}
