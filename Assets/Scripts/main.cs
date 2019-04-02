using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class main : MonoBehaviour
{
	int max=4;
	int [,] arr = new int[4,4];
	System.Random random = new System.Random();
	// Start is called before the first frame update
	void Start()
	{
		for(int i=0;i<4;i++){
			for(int j=0;j<4;j++){
				arr[i,j]=0;
			}
		}
	}

	// Update is called once per frame
	void Update()
	{
			
	}

	void goLeft(){
		for(int row=0;row<max;row++){
			int col=0;
			while(col<max){
				if(arr[row,col]==0){
					col++;
					continue;
				}
				else{
					int col2 = col+1;
					while(col2<max){
						if(arr[row,col2]==0){
							col2++;
							continue;
						}
						else{
							if(arr[row,col]==arr[row,col2]){
								arr[row,col]=2*arr[row,col2];
								arr[row,col2]=0;
								break;
							}
							else{
								break;
							}
						}
					}
					col++;
				}
			}
		}
		for(int row=0;row<max;row++){
			int col=0;
			bool changeFlag=false;
			int minCol=0;
			while(col<max){
				if(arr[row,col]==0){
					col++;
					continue;
				}
				else{
					int col2 =col-1;
					while(col2>=0){
						if(arr[row,col2]==0){
							minCol=col2;
							changeFlag=true;
						}
						col2--;
					}
					if(changeFlag){
						arr[row,minCol]=arr[row,col];
						arr[row,col]=0;
						changeFlag=false;
					}
					col++;
					continue;
				}
			}
		}
	}

	void goRight(){
		for(int row=0;row<4;row++){
			int col=3;
			while(col>=0){
				if(arr[row,col]==0){
					col--;
					continue;
				}
				else{
					int col2 = col-1;
					while(col2>=0){
						if(arr[row,col2]==0){
							col2--;
							continue;
						}
						else{
							if(arr[row,col]==arr[row,col2]){
								arr[row,col]=2*arr[row,col2];
								arr[row,col2]=0;
								break;
							}
							else{
								break;
							}
						}
					}
					col--;
				}
			}
		}
		for(int row=0;row<max;row++){
			int col=3;
			bool changeFlag=false;
			int minCol=0;
			while(col>=0){
				if(arr[row,col]==0){
					col--;
					continue;
				}
				else{
					int col2 =col+1;
					while(col2<max){
						if(arr[row,col2]==0){
							minCol=col2;
							changeFlag=true;
						}
						col2++;
					}
					if(changeFlag){
						arr[row,minCol]=arr[row,col];
						arr[row,col]=0;
						changeFlag=false;
					}
					col--;
					continue;
				}
			}
		}
	}

	void goUp(){
		for(int col=0;col<max;col++){
			int row=0;
			while(row<max){
				if(arr[row,col]==0){
					row++;
					continue;
				}
				else{
					int row2=row+1;
					while(row2<max){
						if(arr[row2,col]==0){
							row2++;
							continue;
						}
						else{
							if(arr[row,col]==arr[row2,col]){
								arr[row,col] = 2*arr[row2,col];
								arr[row2,col]=0;
								break;
							}
							else{
								break;
							}
						}
					}
					row++;
				}
			}
		}

		for(int col=0;col<max;col++){
			int row=0;
			bool changeFlag = false;
			int minRow=0;
			while(row<max){
				if(arr[row,col]==0){
					row++;
					continue;
				}
				else{
					int row2=row-1;
					while(row2>=0){
						if(arr[row2,col]==0){
							minRow= row2;
							changeFlag=true;
						}
						row2--;
					}
					if(changeFlag){
						arr[minRow,col]=arr[row,col];
						arr[row,col]=0;
						changeFlag=false;
					row++;
					continue;
					}
				}
			}
		}
	}

	void goDown(){
		for(int col=0;col<max;col++){
			int row=3;
			while(row>=0){
				if(arr[row,col]==0){
					row--;;
					continue;
				}
				else{
					int row2=row-1;
					while(row2>=0){
						if(arr[row2,col]==0){
							row2--;
							continue;
						}
						else{
							if(arr[row,col]==arr[row2,col]){
								arr[row,col] = 2*arr[row2,col];
								arr[row2,col]=0;
								break;
							}
							else{
								break;
							}
						}
					}
					row--;
				}
			}
		}

		for(int col=0;col<max;col++){
			int row=3;
			bool changeFlag = false;
			int minRow=0;
			while(row>=0){
				if(arr[row,col]==0){
					row--;
					continue;
				}
				else{
					int row2=row+1;
					while(row2>=0){
						if(arr[row2,col]==0){
							minRow= row2;
							changeFlag=true;
						}
						row2++;
					}
					if(changeFlag){
						arr[minRow,col]=arr[row,col];
						arr[row,col]=0;
						changeFlag=false;
					row--;
					continue;
					}
				}
			}
		}
	}

	void insertNew(){
		bool flag=true;
		int counter=0;
		while(flag){
			int row = random.Next(0,4);
			int col= random.Next(0,4);

			if(arr[row,col] == 0){
				arr[row,col]=2;
				flag= false;
			}
			counter++;
			if(counter==16){
				Debug.Log("Game over");
				flag=false;
			}
		}
	}

	void updateData(){
		for(int i =0;i<max;i++){
			for(int j=0;j<max;j++){
				//place things here as arr[j,i]
			}
		}
	}
}



