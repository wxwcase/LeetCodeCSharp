public class Solution 
{
	public bool CanWinNim(int n) 
	{
		// If 4 stones are left, you'll never win
		return (n % 4) != 0;
	}
}
