using System;

public class Player
{
	private int _count;
	private String _countText;
	private int _maxCount = 12;

	public Player (int count)
	{
		this._count = count;
	}

	public void increaseCountBy(int count){
		this._count = this._count + count;
	}

	public String getCountText(){
		return "Count: " + this._count.ToString ();
	}

	public bool isWinner() 
	{
		if (this._count >= this._maxCount) 
		{
			return true;
		}
		return false;
	}


}
