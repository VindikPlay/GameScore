   M S B A M L   `   `   `  ����D  @GameStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GameStore	GameStore  5   	        GameStore.views.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:GameStore     5   	   -   5          �Name$  mw��5       � Title$ 
MainWindow��5
   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�65    � WindowStyle$
 None=�6K    � WindowStartupLocation$ CenterScreen=�6^   .��5      � -   5         �Name$ maingrid��5       J� RenderTransformOrigin$ 0.5,0.5&�6    � RowDefinitions 5      �� 5      $��40 �6   �� 5      $	��410 �6   .+�5      � $��1��6	   ��5      �� 5         AuthBack �� ImageSource# [  6    5      �� 5      $	��28* �6   �� 5      $	��24* �6   �� 5      $	��14* �6   �� 5      $	��25* �6   �� 5      $	��35* �6   �� 5      $	��16* �6   �� 5      $	��75* �6   	 � ColumnDefinitions	 5      �� 5      $	��83* �6   �� 5       $
��312* �6   �� 5!      $
��405* �6   .+�5#      �� -   5        
 ��Name$
 db_login��5#   �   $��Showcard Gothic)�6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ login��6*   
����� �$��1��6c   $��1��6p   $��25(�6�   $��Italic$�6�   $
��Bold"�6�    � Cursor$ Arrow��6�   �� 5$      -   5        $
 db_pass��5$   b   $
 pass��6   
����� �$��3��6E   $��1��6R   $��25(�6s   $ Arrow��6�   $��Italic$�6�   $
��Bold"�6�   $��Showcard Gothic)�6�   � 5%      $��5��6
   $��1��6   	 5&      �� 5'      $
��130* �6   �� 5(      $	��50* �6   �� 5)      $
��130* �6   .+�5+      �� -   5         ��Name$ blogin��5-      $��0��5+      $��0��5,      $��Showcard Gothic)�5.      $	��log��5/      $��20(�6#   $
 Hand��61   ��50      �� *	OpenStore+�� 51      -   5        $
 breg��55      $��2��51      $��0��52      $��Sing UP��54      $��20(�6'   $��Showcard Gothic)�55   #   $
 Hand��6@   ��53      �� *ChangeToRegWindow+55   @   56      57      58      5;      