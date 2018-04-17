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

	private TextMessage deadEnd = new TextMessage ();
	public void Start () {
		msgOne.messageContent = "\"Hey r u on ur way to my place rn";
		msgOne.optionAReplyTxt = "yeah why";
		msgOne.optionAReply = msgTwo;
		msgOne.optionBReplyTxt = "not yet";
		msgOne.optionBReply = msgFive;
		msgOne.optionCReplyTxt = "on my way";
		msgOne.optionCReply = msgTwo;
		msgOne.optionDReplyTxt = "in a min";
		msgOne.optionDReply = msgFive;
		msgOne.delay = .5f;

		msgTwo.messageContent = "\"Can you grab some munchies";
		msgTwo.optionAReply = msgThree;
		msgTwo.optionBReply = msgThree;
		msgTwo.optionCReply = msgThree;
		msgTwo.optionDReply = msgThree;
		msgTwo.optionAReplyTxt = "no I'm driving";
		msgTwo.optionBReplyTxt = "ye were at";
		msgTwo.optionCReplyTxt = "im not hungry";
		msgTwo.optionDReplyTxt = "ilstopatbk";
		msgTwo.delay = 2.0f;


		msgThree.messageContent = "\"Hey you almost there yet?";
		msgThree.optionAReply = msgFour;
		msgThree.optionBReply = msgFour;
		msgThree.optionCReply = msgFour;
		msgThree.optionDReply = msgFour;
		msgThree.optionAReplyTxt = "ye";
		msgThree.optionBReplyTxt = "no";
		msgThree.optionCReplyTxt = "haventleftinayet";
		msgThree.optionDReplyTxt = "stop texting me";
		msgThree.delay = 3.0f;

		msgFour.messageContent = "\"What is taking so long?";
		msgFour.optionAReply = msgFive;
		msgFour.optionBReply = msgFive;
		msgFour.optionCReply = msgFive;
		msgFour.optionDReply = msgFive;
		msgFour.optionAReplyTxt = "I'm driving chill";
		msgFour.optionBReplyTxt = "traffic";
		msgFour.optionCReplyTxt = "sry";
		msgFour.optionDReplyTxt = "almost there";
		msgFour.delay = 3.0f;

		msgFive.messageContent = "\"Well hurry up";
		msgFive.optionAReply = deadEnd;
		msgFive.optionBReply = deadEnd;
		msgFive.optionCReply = deadEnd;
		msgFive.optionDReply = deadEnd;
		msgFive.optionAReplyTxt = "I'm trying";
		msgFive.optionBReplyTxt = "this is as fast as I can go";
		msgFive.optionCReplyTxt = "no";
		msgFive.optionDReplyTxt = "I'd be there if I weren't texting;";
		msgFive.delay = 1.0f;

		deadEnd.messageContent = "\"DEAD END";
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



