   M S B A M L   `   `   `  ����G  CSolitaire v2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Solitaire_v2.UserControlsSolitaire_v2.UserControls  5      )    #Solitaire_v2.UserControls.Solitaire   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <Controls'clr-namespace:Solitaire_v2.UserControls     5      .��5	      �� -   5        $��SuperCanvas��5	      
������ ��6�   ��   �� RelativeSource  ��  �� Mode$ FindAncestor=� �� AncestorLevel$ 1�� �� AncestorType
 Window �� Path$ ActualWidth���6   ��   �� $ FindAncestor=�$ 1��
 Window$ ActualHeight�.+�5
   
   � ��6   ��   �� $ FindAncestor=�$ 1��
 Canvas$ ActualWidth���6�   ��   �� $ FindAncestor=�$ 1��
 Canvas$ ActualHeight� � RowDefinitions 5      �� 5      $��1* �6    �� 5      $��2* �6    .+�5      � $��0��6    � ColumnDefinitions 5      �� 5      $��3* �6'   64   �� 5      $��4* �6'   64   .+�5      � $��0��6    5      �� 5      �� 5      �� 5      .+�5      �� $��
15 10 15 0q�6   
�������$��2q�6E   ._�5      %   Solitaire_v2.UserControls.Stock  -   5          Name$ Stock��5   �   
������ $��4,5,4,0q�6B    K� ZIndex$ 0��6S   	 J� 	AllowDrop$
	 True��6d   $��0��6u   .+�5      �� -   5        $��
StockImage��5   $   $��/Resources/Backface.png��66   ��6W   ��   �� $ 1��
 Canvas$ FindAncestor=�$ ActualWidth�6�   5      5      %   Solitaire_v2.UserControls.Waste  5      -   5        
  Name$
 Waste��5   �   $��1��6)   $��
20,17,20,0q�6=   $ 0��6Q   $
	 True��6b   $��1��6s   6�   5       � 5!      $��1��6    5"      �� 5#      �� 5$      �� 5%      �� 5&      .+�5(      �� $��0��6   $��	15,5,15,5q�6-   
�������$��2q�6T   ._�5)      *   $Solitaire_v2.UserControls.Foundation  -   5          Name$ StackOne��5)   �   *   $Solitaire_v2.UserControls.Foundation   
MouseEnter$ EventMouseEnter��6i      
MouseLeave$ EventMouseExit��6�   $��5,5,5,5q�6.   
������ $ 0��6X   $
	 True��6�   6�   5*      �� 5+      $��1��6   $��	15,5,15,5q�6-   
�������$��2q�6T   ._�5,        -   5        $ StackTwo��5,   �   $ EventMouseEnter��6i   $ EventMouseExit��6�   $��5,5,5,5q�6.   
������ $ 0��6X   $
	 True��6�   6�   5-      �� 5.      $��2��6   $��	15,5,15,5q�6-   
�������$��2q�6T   ._�5/        -   5        $ 
StackThree��5/   �   $ EventMouseEnter��6i   $ EventMouseExit��6�   $��5,5,5,5q�6.   
������ $ 0��6X   $
	 True��6�   6�   50      �� 51      $��3��6   $��	15,5,15,5q�6-   
�������$��2q�6T   ._�52        -   5        $ 	StackFour��52   �   $ EventMouseEnter��6i   $ EventMouseExit��6�   $��5,5,5,5q�6.   
������ $ 0��6X   $
	 True��6�   6�   53      54      55      � 56      $��1��6    57      �� 58      �� 59      �� 5:      �� 5;      �� 5<      �� 5=      �� 5>      .+�5@      $   Solitaire_v2.UserControls.Pile  -	   5          Name$ PileOne��5@       $   Solitaire_v2.UserControls.Pile   
MouseEnter$ EventMouseEnter��6�      
MouseLeave$ EventMouseExit��6�   
������ $��0��6L   $��
20 20 20 0q�6\   $
	 True��6p   $ 0��6�     5A      -
   5        $ PileTwo��5A       $ EventMouseEnter��6�   $ EventMouseExit��6�   
������ $��1��6L   $��
20 20 20 0q�6\   $
	 True��6p   $ 0��6�     5B      -   5        $ 	PileThree��5B       $ EventMouseEnter��6�   $ EventMouseExit��6�   
������ $��2��6L   $��
20 20 20 0q�6\   $
	 True��6p   $ 0��6�     5C      -   5        $ PileFour��5C       $ EventMouseEnter��6�   $ EventMouseExit��6�   
������ $��3��6L   $��
20 20 20 0q�6\   $
	 True��6p   $ 0��6�     5D      -   5        $ PileFive��5D       $ EventMouseEnter��6�   $ EventMouseExit��6�   
������ $��4��6L   $��
20 20 20 0q�6\   $
	 True��6p   $ 0��6�     5E      -   5        $ PileSix��5E       $ EventMouseEnter��6�   $ EventMouseExit��6�   
������ $��5��6L   $��
20 20 20 0q�6\   $
	 True��6p   $ 0��6�     5F      -   5        $ 	PileSeven��5F       $ EventMouseEnter��6�   $ EventMouseExit��6�   
������ $��6��6L   $��
20 20 20 0q�6\   $
	 True��6p   $ 0��6�   5G      5H      5I      5J      