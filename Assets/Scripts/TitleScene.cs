﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TitleScene : MonoBehaviour {

	string mainText="ルイズ！ルイズ！ルイズ！ルイズぅぅうううわぁああああああああああああああああああああああん！！！\nあぁああああ…ああ…あっあっー！あぁああああああ！！！ルイズルイズルイズぅううぁわぁああああ！！！\nあぁクンカクンカ！クンカクンカ！スーハースーハー！スーハースーハー！いい匂いだなぁ…くんくん\nんはぁっ！ルイズ・フランソワーズたんの桃色ブロンドの髪をクンカクンカしたいお！クンカクンカ！あぁあ！！\n間違えた！モフモフしたいお！モフモフ！モフモフ！髪髪モフモフ！カリカリモフモフ…きゅんきゅんきゅい！！\n小説12巻のルイズたんかわいかったよぅ！！あぁぁああ…あああ…あっあぁああああ！！ふぁぁあああんんっ！！\nアニメ2期放送されて良かったねルイズたん！あぁあああああ！かわいい！ルイズたん！かわいい！あっああぁああ！\nコミック2巻も発売されて嬉し…いやぁああああああ！！！にゃああああああああん！！ぎゃああああああああ！！\nぐあああああああああああ！！！コミックなんて現実じゃない！！！！あ…小説もアニメもよく考えたら…\nル イ ズ ち ゃ ん は 現実 じ ゃ な い？にゃあああああああああああああん！！うぁああああああああああ！！\nそんなぁああああああ！！いやぁぁぁあああああああああ！！はぁああああああん！！ハルケギニアぁああああ！！\nこの！ちきしょー！やめてやる！！現実なんかやめ…て…え！？見…てる？表紙絵のルイズちゃんが僕を見てる？\n表紙絵のルイズちゃんが僕を見てるぞ！ルイズちゃんが僕を見てるぞ！挿絵のルイズちゃんが僕を見てるぞ！！\nアニメのルイズちゃんが僕に話しかけてるぞ！！！よかった…世の中まだまだ捨てたモンじゃないんだねっ！\nいやっほぉおおおおおおお！！！僕にはルイズちゃんがいる！！やったよケティ！！ひとりでできるもん！！！\nあ、コミックのルイズちゃああああああああああああああん！！いやぁあああああああああああああああ！！！！\nあっあんああっああんあアン様ぁあ！！シ、シエスター！！アンリエッタぁああああああ！！！タバサｧぁあああ！！\nううっうぅうう！！俺の想いよルイズへ届け！！ハルケギニアのルイズへ届け！\n";
	[SerializeField]
	Text textField;
	// Use this for initialization
	void Start () {
		StartCoroutine ("LoadText");
	}
	
	// Update is called once per frame
	void Update () {
	
		SetNextScene ();
	}
	void SetNextScene(){
		if (Input.GetButtonDown ("Decide")) {
			GameManager.Instance.GoNextScene ("MainScene");
		}
	}
	//こルーチンでテキストを流す
	IEnumerator LoadText(){
		foreach (var text in mainText) {
			textField.text += text;
			yield return new WaitForSeconds (0.1f);
		}
	}
}
