   M S B A M L   `   `   `  ����  Junk Drawer$    Junk_Drawer.Windows.SubmitIdea   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
SubmitIdea��5   	   $	��300��6   $	��300��6)   .��5      �  � RowDefinitions 5   
   �� 5      $	��25* �6   �� 5      $	��25* �6   �� 5	      $	��25* �6   �� 5
      $	��25* �6    � ColumnDefinitions 5   
   �� 5      $	��50* �6   �� 5      $	��50* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��0��6,   $��0��69   .+�5      �� $��	Idea Name��6   �� 5      $��5q�6   ��6!   �� *
IdeaName+ �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5   
   $ Vertical=�6   $��0��6,   $��1��69   .+�5      �� $��Submitting as:��6   �� 5      $��5q�6   ��6#   �� *Who+5      � 5   
   $��1��6   $��0��6   $��2��6-    5      �� 5      $
��Auto �6    �� 5      $��* �6     5!      �� 5"      $	��50* �6#   �� 5#      $	��50* �6#   .+�5&      �� $��0��6   $��0��6!   $��2��61   $��Description��6E   �� 5'       �� TextWrapping$
 Wrap=�6   $��1��6*   $��0��5)      $��2��6&   ��5(      �� *Description+$ PropertyChanged=�5)   &   5*      �� 5,   
   $ Vertical=�6   $��2��6,   $��0��69   .+�5-      �� $��Category��6   �� 5.      $��5q�6    �� SelectedIndex$ 0��5/       �� SelectedValuePath$ 
CategoryID��50       �� DisplayMemberPath$ CategoryName��51      ��5.   "   �� *
Categories+	 �� SelectedItem	 52      �� *
Category+$ PropertyChanged=�53      �� 55   
   -   5        $��3��55      $��0��6   $��2��6.   $��20q�6B   $��Submit��6N   6_   57      58      