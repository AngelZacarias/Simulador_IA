   M S B A M L   `   `   `  ����G  CSimulador_IA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Simulador_IASimulador_IA  5   	       Simulador_IA.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Simulador_IA     5   	     � Title$  Window1��5   	   $��538.8��6   $��357.6��6(    � WindowStyle$
 None=�66   .��5	      � $	��350��6   $��0,10,0,2q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridScore��5
      $	��340��6*   $��
10,65,10,0q�67   $	��Top=�6K   ���	#FF134183   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Movements��6%      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6m   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   ��  �� Path$ 	Movements�6{     5      $ Trash��6%    . $	 150 6e    6F   �� $ Trash�6s   5      �� 5   
   $��Scores and Analytics��6   $��
10,10,10,0q�6/   $	��Top=�6C   $��37��6[   $��20(�6g   $
��Bold"�6u   ���	#FF134183$��Center=�6�   �� 5   
   -   5        	 ��Name$	 LBL_Movements��5      $�� ��6'   $
��Left=�62   $��
10,416,0,0q�6M   $	��Top=�6a   $	��141��6y   ���	#FF134183$��Center=�6�   $
��Bold"�6�   �� 5   
   -   5        $	 	LBL_Trash��5      $�� ��6#   $
��Left=�6.   $��198,416,0,0q�6I   $	��Top=�6^   $	��141��6v   ���	#FF134183$��Center=�6�   $��15(�6�   $
��Bold"�6�   �� 5   
   -   5        
 ��Name$
 	BTN_Close��5      $��Close��6$   $��	4,0,10,10q�64   
�������$��	Open Sans)�6u   ���	#FF134183$��20(�6�   $��36��6�   $��Bottom=�6�   ��6�   Z� 6�   �� 5   
   -   5        $	 LBL_LegendMovements��5      $��Movements Average��6-   $
��Left=�6I   ���	#FF134183$��	Open Sans)�6{   $��23��6�   $��Bottom=�6�   $��Center=�6�   $	��141��6�   $��9(�6�   $��	10,0,0,59q�6�   �� 5   
   -   5        $	 LBL_LegendMovements_Copy��5      $��Cleaned Trashs Average��62   $
��Left=�6S   ���	#FF134183$��	Open Sans)�6�   $��23��6�   $��Bottom=�6�   $��Center=�6�   $	��141��6�   $��9(�6�   $��
198,0,0,59q�6   5      5      