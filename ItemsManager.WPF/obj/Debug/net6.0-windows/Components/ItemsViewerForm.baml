   M S B A M L   `   `   `  ����K  GItemsManager.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ItemsManager.WPF.ComponentsItemsManager.WPF.Components  5      1    +ItemsManager.WPF.Components.ItemsViewerForm   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ItemsManager.WPF.Components     5      -   5          >�Name$  ThisPage��5      .��5
      � $��20q�6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� .+�5      �� $	��All��6   $	��150��6#   $
��Bold"�6/   $	��All��5   !   ��5   !   �� *FilterViewCommand+5   !   �� 5   
   -   5         ��Name$ BtnsList��5      $��0��6%   $��0q�65   $��Center=�5      ��67   �� *ItemTypesList+��5      �� 5      .R�5      �� .+�5      �� $	��150��65   $
��Bold"�6A   ��6!   �� ��5   !   ��  �� Source %  System.Windows.Markup.Reference  *
ThisPage+ �� Path$# DataContext.FilterViewCommand���5   !   �� 5      5      5       5!      �� 5%   
   -   5        $ itemView��5%      $��0q�6&   $��Stretch=�6:   $	��Top=�5&      $��1��6M   ��6+   �� *	ItemsData+��5'      �� 5(      .R�5)      A�  A� Columns$ 5��6"   $��Center=�6.   5*      ��5,      �� 5-      .R�5.      � $��Center=�6    � IsSharedSizeScope$
 True��68   .+�5/      ��  �� CornerRadius$ 1��6!   
�������
�������$��1q�52   !    �� Padding$ 8q�53   !   ._�54      �� $	��120��6)   .+�55   "   �� $��50��6L   $��50��6W   ��6(   �� $ ImageSource�6W   � 57   "   .+�58   &   �� $��	Item ID: ��6,   $
��Bold"�6@   �� 59   &   	 �� TextAlignment$	 Center=�6M   $��Center=�6d   ��60   �� $ ItemID�6d   5:   #   � 5;   "   .+�5<   &   �� $��Price: ��6,   $
��Bold"�6>   �� 5=   &   $	 Center=�6L   $��Center=�6c   ��60   �� $ Price�6c   5>   #   � 5?   "   .+�5@   &   �� $��
Category: ��6,   $
��Bold"�6A   �� 5A   &   $	 Center=�6O   $��Center=�6f   ��60   �� $ Category�6f   5B   #   2   ,ItemsManager.WPF.Components.ItemDropDownMenu  5C   "   $��25��69   $��0 0 0 0q�6D   $��Right=�6U   5D      5E      5F      5G      5I      5M      5N      