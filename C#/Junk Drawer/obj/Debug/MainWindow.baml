   M S B A M L   `   `   `  ����F  BJunk Drawer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Junk_Drawer.ControlsJunk_Drawer.Controls  5   	       Junk_Drawer.MainWindow   5   	   /controls"clr-namespace:Junk_Drawer.Controls  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��750��6)   $	��650��65   $	��350��6D   .��5      �  � RowDefinitions 5   
   �� 5	      $
��Auto �6   �� 5
      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   � $��0��6   $��0��6    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6     5      �� 5      $��* �6#   �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      �� $��Submit An Idea��6   $��0��6.   $��1��6;   ��6K   �� *CreateCommand+�� 5!       �� Orientation$ Vertical=�6   $��0��60   $��2��6=   $��2��6N   .+�5"      �� $(��"Voting, linking and submitting as:��6   $��10(�5#      $��2��6$   �� 5%      ��5&      �� 5'      .�5(      ��  �� Property � �� �� Value 6>   �� *EmailAddress+ �� Triggers 5)      �� 5*   "    �� Binding 6.   �� *IsAnonymous+ �� Value True6N   .a�5+   &   ��  � ��$ 	Anonymous��6F   5,   #   5.      50      51      53      �� 55   
   $��1��6   $��0��6#   .@�57      �� ��58      �� 59      $��Half Baked Ideas��6   .��5<      *   $Junk_Drawer.Controls.BadIdeasControl  5=      �� 5?      ��5@      �� 5A      $��Better Ideas��6   .��5C      +   %Junk_Drawer.Controls.GoodIdeasControl  5D      �� 5F      ��5G      �� 5H      $��In Production��6   5J      5L      '   !Junk_Drawer.Controls.LoginControl  5N   
   $��1��6    $��2��64   $��Stretch=�5O   $   $��Stretch=�5P   $   $��0��5Q   $   $��0��64   ��5S      �� 5T      .�5U      ��  � y�$ Hidden=�6I    5V      �� 5W       6&   �� *
IsLoggedIn+	 false6E   .a�5X      ��  � y�$ Visible=�6Q   5Y      5[      5]      5_      5`      