   M S B A M L   `   `   `  ����F  BJunk Drawer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Junk_Drawer.ControlsJunk_Drawer.Controls  5      *    $Junk_Drawer.Controls.BadIdeasControl   5      /controls"clr-namespace:Junk_Drawer.Controls  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Stretch=�6P   $��Disabled=�5       �� SelectedIndex$ 0��5   \   ��5   /   �� *
BadIdeas+ �� SelectedItem 5      �� *CurrentIdea+ �� UpdateSourceTrigger$ PropertyChanged=���5      �� 5      .R�5      �   5      �� 5      $
��100* �6/    5       �� 5!      $	��10* �6,   �� 5"      $	��90* �6,   .+�5%      � $��0��6   $��0��6/     5'      �� 5(   "   $
��Auto �63   �� 5)   "   $��* �63   �� 5*   "   $
��Auto �63    5-      �� 5.   "   $
��100* �60   .+�52      �� $��0��6(   $��0��65   $��25(�6E   ��6S   ��  �� Path$ IdeaName��� 54      $��0��6)   $��2��66    �� Orientation$ 
Horizontal=�6F   .+�55   "   �� $��16(�6,   $
��Bold"�6:   $��Expires on ��6M   �� 56   "   $��16(�6,   $
��Bold"�6:   ��6L   �� $ 
Expiration�58      5:      4   .Junk_Drawer.Controls.BadIdeaDescriptionControl  5<      $��1��6=   $��0��6J   $��3��6Z   ��5=      �� 5>   "   .�5?   &   ��  �� Property � y� �� Value$ 	Collapsed=�6f   	 �� Triggers	 5@   &   �� 5A   *   
 �� Binding
 66   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" ��$ 
IsSelected� �� Value True5C   S   .a�5D   .   ��  � y�$ Visible=�6n   5E   +   5G   #   5I      5K      5L      5P      5T      5V      