using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum ResponseOption {
	OptionA, OptionB, OptionC, OptionD, NoOption
}

public class TextBank {
	public TextMessage getStartingMessage() {
		return msgOne;
	}

	private TextMessage msgOne = new TextMessage ();
	private TextMessage msgTwo = new TextMessage ();
	private TextMessage msgThree = new TextMessage ();
	private TextMessage msgFour = new TextMessage ();
	private TextMessage msgFive = new TextMessage ();
	private TextMessage msgSix = new TextMessage ();
	private TextMessage msgSeven = new TextMessage ();
	private TextMessage msgEight = new TextMessage ();
	private TextMessage msgNine = new TextMessage ();
	private TextMessage msgTen = new TextMessage ();
	private TextMessage msgEleven = new TextMessage ();
	private TextMessage msgTwelve = new TextMessage ();
	private TextMessage msgThirteen = new TextMessage ();
	private TextMessage msgFourteen = new TextMessage ();


	private TextMessage deadEnd = new TextMessage ();
	public void Start () {
		msgOne.messageContent = "\"Hey r u on ur way to my place rn\"\n";
		msgOne.optionAReplyTxt = "yeah why";
		msgOne.optionAReply = msgTwo;
		msgOne.optionBReplyTxt = "not yet";
		msgOne.optionBReply = msgFive;
		msgOne.optionCReplyTxt = "on my way";
		msgOne.optionCReply = msgTwo;
		msgOne.optionDReplyTxt = "in a min";
		msgOne.optionDReply = msgFive;
		msgOne.delay = 0.5f;

		msgTwo.messageContent = "\"Can you grab some munchies?\"\n";
		msgTwo.optionAReply = msgThree;
		msgTwo.optionBReply = msgThree;
		msgTwo.optionCReply = msgThree;
		msgTwo.optionDReply = msgThree;
		msgTwo.optionAReplyTxt = "no I'm driving";
		msgTwo.optionBReplyTxt = "ye were at";
		msgTwo.optionCReplyTxt = "im not hungry";
		msgTwo.optionDReplyTxt = "ill stop at bk";
		msgTwo.delay = 4.5f;


		msgThree.messageContent = "\"Hey you almost there yet?\"\n";
		msgThree.optionAReply = msgFour;
		msgThree.optionBReply = msgFour;
		msgThree.optionCReply = msgFour;
		msgThree.optionDReply = msgFour;
		msgThree.optionAReplyTxt = "ye";
		msgThree.optionBReplyTxt = "no";
		msgThree.optionCReplyTxt = "haven't left yet";
		msgThree.optionDReplyTxt = "stop texting me";
		msgThree.delay = 7.0f;

		msgFour.messageContent = "\"What is taking so long?\"\n";
		msgFour.optionAReply = msgFive;
		msgFour.optionBReply = msgFive;
		msgFour.optionCReply = msgFive;
		msgFour.optionDReply = msgFive;
		msgFour.optionAReplyTxt = "I'm driving chill";
		msgFour.optionBReplyTxt = "traffic";
		msgFour.optionCReplyTxt = "sry";
		msgFour.optionDReplyTxt = "almost there";
		msgFour.delay = 4.5f;

		msgFive.messageContent = "\"Well hurry up\"\n";
		msgFive.optionAReply = msgSix;
		msgFive.optionBReply = msgSix;
		msgFive.optionCReply = msgSix;
		msgFive.optionDReply = msgSix;
		msgFive.optionAReplyTxt = "I'm trying";
		msgFive.optionBReplyTxt = "this is as fast as I can go";
		msgFive.optionCReplyTxt = "no";
		msgFive.optionDReplyTxt = "I'd be there if I weren't texting";
		msgFive.delay = 4.5f;

		msgSix.messageContent = "\"hey! have u heard the news??\"\n";
		msgSix.optionAReply = msgSeven;
		msgSix.optionBReply = msgSeven;
		msgSix.optionCReply = msgSeven;
		msgSix.optionDReply = msgSeven;
		msgSix.optionAReplyTxt = "no! what's up?";
		msgSix.optionBReplyTxt = "mmm. i don't think so...";
		msgSix.optionCReplyTxt = "lol no. tell me!";
		msgSix.optionDReplyTxt = "ofc. i've heard enough of it";
		msgSix.delay = 7.5f;

		msgSeven.messageContent = "\"Khloe Kardashian is pregnant!! pic on insta\"\n";
		msgSeven.optionAReply = msgEight;
		msgSeven.optionBReply = msgEight;
		msgSeven.optionCReply = msgNine;
		msgSeven.optionDReply = msgEight;
		msgSeven.optionAReplyTxt = "what!?!? GET OUT!!";
		msgSeven.optionBReplyTxt = "no way!";
		msgSeven.optionCReplyTxt = "oh lol. that's old news";
		msgSeven.optionDReplyTxt = "please. idk y u follow that stuff";
		msgSeven.delay = 4.5f;

		msgEight.messageContent = "\"please tell me yur close\"\n";
		msgEight.optionAReply = msgTen;
		msgEight.optionBReply = msgTen;
		msgEight.optionCReply = msgTen;
		msgEight.optionDReply = msgTen;
		msgEight.optionAReplyTxt = "ye which apt was it again";
		msgEight.optionBReplyTxt = "where should i park";
		msgEight.optionCReplyTxt = "nope";
		msgEight.optionDReplyTxt = "5 min";
		msgEight.delay = 7.5f;

		msgNine.messageContent = "\"did you know teens are 4x more likely than adults to crash or almost crash when on a cell phone?\"\n";
		msgNine.optionAReply = msgTen;
		msgNine.optionBReply = msgTen;
		msgNine.optionCReply = msgTen;
		msgNine.optionDReply = msgTen;
		msgNine.optionAReplyTxt = "oh wow";
		msgNine.optionBReplyTxt = "no way!";
		msgNine.optionCReplyTxt = "yikes";
		msgNine.optionDReplyTxt = "¯\\_(ツ)_/¯ ";
		msgNine.delay = 6.5f;

		msgTen.messageContent = "\"I just heard the funniest joke! wanna hear it?\"\n";
		msgTen.optionAReply = msgEleven;
		msgTen.optionBReply = msgTwelve;
		msgTen.optionCReply = msgTwelve;
		msgTen.optionDReply = msgEleven;
		msgTen.optionAReplyTxt = "yeah sure";
		msgTen.optionBReplyTxt = "ugh. ur jokes are never funny";
		msgTen.optionCReplyTxt = "mmmm i'll pass";
		msgTen.optionDReplyTxt = "okay. but it better be good...";
		msgTen.delay = 6.5f;

		msgEleven.messageContent = "\"knock knock\"\n";
		msgEleven.optionAReply = msgThirteen;
		msgEleven.optionBReply = msgThirteen;
		msgEleven.optionCReply = msgThirteen;
		msgEleven.optionDReply = msgThirteen;
		msgEleven.optionAReplyTxt = "who's there?";
		msgEleven.optionBReplyTxt = "whomst approacheth my abode?";
		msgEleven.optionCReplyTxt = "no soliciting";
		msgEleven.optionDReplyTxt = "stahp.";
		msgEleven.delay = 4.5f;

		msgTwelve.messageContent = "\"Ur gonna hear it anyway. knock knock\"\n";
		msgTwelve.optionAReply = msgThirteen;
		msgTwelve.optionBReply = msgThirteen;
		msgTwelve.optionCReply = msgThirteen;
		msgTwelve.optionDReply = msgThirteen;
		msgTwelve.optionAReplyTxt = "who's there?";
		msgTwelve.optionBReplyTxt = "whomst approacheth my abode?";
		msgTwelve.optionCReplyTxt = "no soliciting";
		msgTwelve.optionDReplyTxt = "stahp.";
		msgTwelve.delay = 5.0f;

		msgThirteen.messageContent = "\"Ur car\"\n";
		msgThirteen.optionAReply = msgFourteen;
		msgThirteen.optionBReply = msgFourteen;
		msgThirteen.optionCReply = msgFourteen;
		msgThirteen.optionDReply = msgFourteen;
		msgThirteen.optionAReplyTxt = "Ur car who?";
		msgThirteen.optionBReplyTxt = "Ur car or my car?";
		msgThirteen.optionCReplyTxt = "im not doing this";
		msgThirteen.optionDReplyTxt = "stahp.";
		msgThirteen.delay = 5.0f;

		msgFourteen.messageContent = "\"Ur car shouldnt be knocking, you should get that checked out\"\n";
		msgFourteen.optionAReply = msgOne;
		msgFourteen.optionBReply = msgOne;
		msgFourteen.optionCReply = msgOne;
		msgFourteen.optionDReply = msgOne;
		msgFourteen.optionAReplyTxt = "lol";
		msgFourteen.optionBReplyTxt = "wow";
		msgFourteen.optionCReplyTxt = "hahaha";
		msgFourteen.optionDReplyTxt = "funny...";
		msgFourteen.delay = 5.0f;

		deadEnd.messageContent = "\"DEAD END\"\n";
		deadEnd.optionAReply = deadEnd;
		deadEnd.optionBReply = deadEnd;
		deadEnd.optionCReply = deadEnd;
		deadEnd.optionDReply = deadEnd;
		deadEnd.optionAReplyTxt = "DEAD END";
		deadEnd.optionBReplyTxt = "DEAD END";
		deadEnd.optionCReplyTxt = "DEAD END";
		deadEnd.optionDReplyTxt = "DEAD END";

	}
}

public class TextMessage {
	public string messageContent;
	public TextMessage optionAReply;
	public TextMessage optionBReply;
	public TextMessage optionCReply;
	public TextMessage optionDReply;

	public string optionAReplyTxt;
	public string optionBReplyTxt;
	public string optionCReplyTxt;
	public string optionDReplyTxt;

	public float delay = 0;

	public string FormattedMessage() {
		return messageContent + "\n A) " + this.optionAReplyTxt
		+ "\n B) " + this.optionBReplyTxt
		+ "\n C) " + this.optionCReplyTxt
		+ "\n D) " + this.optionDReplyTxt;
	}
}



