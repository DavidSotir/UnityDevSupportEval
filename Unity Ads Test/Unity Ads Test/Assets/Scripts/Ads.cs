using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour {

	string adID = "video";

	public void ShowAds()
	{
		ShowOptions options = new ShowOptions();
		options.resultCallback = AdsCallback;

		Advertisement.Show(adID, options);
    }

	void AdsCallback(ShowResult result)
	{
		if (result == ShowResult.Finished)
		{
			Debug.Log("Ad Finished!");
			//give reward
		}
		else if (result == ShowResult.Failed)
		{
			Debug.Log("Ad Failed!");
		}
		else if (result == ShowResult.Skipped)
		{
			Debug.Log("Ad Skipped!");
		}
	}
}
