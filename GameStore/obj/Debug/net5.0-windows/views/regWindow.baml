   M S B A M L   `   `   `  ����D  @GameStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:GameStore.viewsGameStore.views  5   	       GameStore.views.RegWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   )localclr-namespace:GameStore.views  5   	   -   5          �Name$  rw��5       � Title$ 	regWindow��5
   	   $	��450��6   $	��800��6(    � WindowStyle$
 None=�64    � WindowStartupLocation$ CenterScreen=�6G    � 
ResizeMode$ NoResize=�6l   .��5      � -   5         �Name$ maingrid��5       � RowDefinitions 5      �� 5      $��40 �6   �� 5      $	��410 �6   .+�5      � $��1��6	   ��5      �� 5         	RegisBack �� ImageSource# [  6    � ColumnDefinitions 5      �� 5      $	��62* �6   �� 5      $
��319* �6   �� 5      $
��419* �6    5      �� 5      $	��47* �6   �� 5      $	��43* �6   �� 5      $��23.522 �6   �� 5      $	��43* �6   �� 5      $	��24* �6   �� 5      $	��43* �6   �� 5       $	��24* �6   �� 5!      $	��43* �6   �� 5"      $	��24* �6   �� 5#      $	��31* �6   �� 5$      $	��47* �6   .+�5&      �� -   5        	 ��Name$		 log��5&      
����� �)  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 login��6,   $��1��6S   $��1��6`   $��Showcard Gothic)�6p   $��20(�6�   �� 5'      -   5        $	 pochta��5'      
����� �$

 mail��6/   $��3��6U   $��1��6b   $��Showcard Gothic)�6r   $��20(�6�   �� 5(      -   5        $
	 pass��5(      
����� �$

 pass��6-   $��5��6S   $��1��6`   $��Showcard Gothic)�6p   $��20(�6�   �� 5)      -   5        $	 rpass��5)      
����� �$
 
repid pass��6.   $��7��6Z   $��1��6g   $��Showcard Gothic)�6w   $��20(�6�   � 5*      $��9��6
   $��1��6    5+      �� 5,      $
��125* �6   �� 5-      $	��53* �6   �� 5.      $
��141* �6   .+�50      �� -   5         ��Name$ bback��52      $��Sing in��50      
����� �$��0��53      $��Showcard Gothic)�54      $��20(�55      ��56      �� *ChangeToMainWindow+��57      ��  �� ElementName$ rw���� 59      -   5        $
 breg��5;      $	��reg��59      
����� �$��2��5<      $��Showcard Gothic)�5=      $��20(�5>      5?      5@      5A      5C      