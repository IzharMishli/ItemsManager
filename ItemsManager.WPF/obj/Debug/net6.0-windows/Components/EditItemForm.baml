   M S B A M L   `   `   `  ����K  GItemsManager.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ItemsManager.WPF.ComponentsItemsManager.WPF.Components  5      .    (ItemsManager.WPF.Components.EditItemForm   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ItemsManager.WPF.Components     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �   5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      � $��0��6    � ColumnDefinitions 5      �� 5      $
��auto �6'   �� 5      $��* �6'   $	��250��61   .+�5      �� $��0��6   $
��Bold"�6,   $��Item ID��6>   �� 5      $��1��6   $��20 0 0 0q�6B   ��6*   �� *ItemID+6B   5      � 5!      $��1��6    5"      �� 5#      $
��auto �6'    z� SharedSizeGroup$ Label��64   �� 5$      $��* �6'   $	��250��61   .+�5'      �� $��0��6   $
��Bold"�6,   $��Category��6>   �� 5(      $��1��6   $��20 0 0 0q�6D   ��6*   �� *
Category+6D   5*      � 5,      $��2��6    5-      �� 5.      $
��auto �6'   $ Label��64   �� 5/      $��* �6'   $	��250��61   .+�52      �� $��0��6   $
��Bold"�6,   $��Price��6>   �� 53      $��1��6   $��20 0 0 0q�6A   ��6*   �� *Price+6A   55      � 57      $��1��6   $��0 30 0 0q�6%   .+�58      �� $��Submit��6   $��0 0 5 0q�5;      ��59      �� *SubmitCommand+{�5:      �� *	CanSubmit+5;      �� 5<      $��Cancel��6      ButtonSecondary#��[  5>      ��5=      �� *CancelCommand+5>      5@      5B      5E      5F      