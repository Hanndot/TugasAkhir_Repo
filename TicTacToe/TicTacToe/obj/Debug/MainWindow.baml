   M S B A M L   `   `   `  ����D  @TicTacToe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TicTacToe	TicTacToe  5   	       TicTacToe.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TicTacToe     5   	     � 
ResizeMode$  NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$ Tugas Akhir - Tic Tac Toe��5
   	   $	��600��6+   $	��600��68    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$ 3q�60   �� 5       � ��
 �   �6,   �� 5       � ��$	 150(�6)   �� 5       � ��$ Courier New)�6+   5      5      .��5      � -   5         �Name$ Kotak��5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   	 � RowDefinitions	 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5"   
   �� -   5        
 ��Name$
 	tombol0_0��5"   &   $��0��69   $��0��6I   $��X��6V   �� 5#   
   -   5        $
 	tombol1_0��5#   &   $��1��69   $��0��6I   $��O��6V   �� 5$   
   -   5        $
 	tombol2_0��5$   &   $��2��69   $��0��6I   �� 5%   
   -   5        $
 	tombol0_2��5%   &   $��0��69   $��2��6I   �� 5&   
   -   5        $
 	tombol1_1��5&   &   $��1��69   $��1��6I   �� 5'   
   -   5        $
 	tombol2_2��5'   &   $��2��69   $��2��6I   �� 5(   
   -   5        $
 	tombol1_2��5(   &   $��1��69   $��2��6I   �� 5)   
   -	   5        $
 	tombol2_1��5)   &   $��2��69   $��1��6I   �� 5*   
   -
   5        $
 	tombol0_1��5*   &   $��0��69   $��1��6I   5+      5,      