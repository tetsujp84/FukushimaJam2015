using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TitleScene : MonoBehaviour {

	string mainText="ここは仙台のとある裏路地\n学校帰りのあなたはいつものように寄り道をします。\nすると傷ついたドラゴンが倒れています\n助けに行こうとすると怖そうな大人たちにかこまれました。\n盗賊「そいつは俺たちが先に見つけたドラゴンだ。」\nはたして盗賊から逃げ無事ドラゴンを助けることができるのか。あなたたちの運命やいかに......(Spaceで飛ぶ)\nZスタート";
	
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
		} else if (Input.GetButtonDown ("Decide2")) {
			GameManager.Instance.GoNextScene ("MainScene2");
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
