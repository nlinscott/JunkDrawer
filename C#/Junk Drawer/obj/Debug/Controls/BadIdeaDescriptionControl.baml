   M S B A M L   `   `   `  ����F  BJunk Drawer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Junk_Drawer.ControlsJunk_Drawer.Controls  5      4    .Junk_Drawer.Controls.BadIdeaDescriptionControl   5      /controls"clr-namespace:Junk_Drawer.Controls  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $��* �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0��6!   �� 5      $�	Creater: ��6    �� 5      �6   ��  �� Path$ Author�5      �� 5   
   $��1��6   $��0��6!   �� 5      $�
Category: ��6    �� 5      �6   �� $ Category�5      �� 5"   
   $
��Wrap=�6   $��2��6(   $��0��65   $��16(�6E   $��0 5 5 5q�6S   ��5#      �� $ Description�� 5&   
   $��0��6   $��1��6   $��3��6,    5'      �� 5(      $
��Auto �6    �� 5)      $
��Auto �6    �� 5*      $
��Auto �6    .+�5.      �� $��18(�6   $��0��6&   $��Center=�5/      $��Center=�6/   ��50      ��  �� RelativeSource �� *FindAncestor+ �� AncestorType*   $Junk_Drawer.Controls.BadIdeasControl"  $ DataContext.Votes� �� UpdateSourceTrigger$ PropertyChanged=��� 54      $��1��6   $��^��6"   $��25��6/   $��25��6:   ��6F   ��  �� *FindAncestor+"  $ DataContext.VoteUpCommand��� 58      $��2��6   $��v��6"   $��25��6.   $��25��69   ��6E   ��  �� *FindAncestor+"  $! DataContext.VoteDownCommand�5<      5@      5A      