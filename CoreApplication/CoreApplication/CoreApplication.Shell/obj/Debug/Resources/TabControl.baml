   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      P LCoreApplication.Shell, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:CoreApplication.Shell.HelpersCoreApplication.Shell.Helpers 5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35   TabControlFontFamily  TabControlHeaderFontSize  TabItemDisabledBackground  �� Color  TabItemDisabledBorderBrush  BoolVisibilityConverter �� 
TargetType �� Property �� Value �� 
TargetType � RowDefinitions ��Name K� ZIndex K� IsItemsHost-   'System.Windows.Input.KeyboardNavigation	    TabIndex
 �Name ��Name �� Padding �� Orientation �� 	Converter.  (System.Windows.Interactivity.Interaction   Triggers/  )System.Windows.Interactivity.EventTrigger   	EventName.  (System.Windows.Interactivity.TriggerBase   Actions2  ,CoreApplication.Shell.Helpers.CloseTabAction �� Triggers P� Property P� Value �� 
TargetName�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      Cei:http://schemas.microsoft.com/expression/2010/interactivity  5      1system&clr-namespace:System;assembly=mscorlib  5      7helpers+clr-namespace:CoreApplication.Shell.Helpers  5      %x  &	        &	 %     &	 ?     &	 `     &	 �     '�� �     '��     7  *�5      Titillium Web)�6=   X�5	      13Q�69   �� 5      $  #F4F4F4��68   �� 5      $  	#FFC9C7BA��69   �� 5      6#   �� 5      " ��6   .�5   
   ��  �@�OverridesDefaultStyle . 62   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �  5      �� 5      $
��Auto �6,   �� 5      $��* �6,   .+�5      �� $ HeaderPanel��6#   $��0��5   #   $ 1��5   #   $��0q�5   #    . $	 1��5   #   
������ 5    #   �� 5!      $��1��6!   ���#aaaaaa$��1,1,1,1q�5#   !   
�������._�5%      �� $��5q�6+   $
��Auto=�5&   +   $
��Auto=�5'   +   .��5(   "   �� $��4q�63   $��SelectedContent��5)   3   5*      5+      5,      5-      5/      50      �� 52      " ��6   .�53   
   ��  �@�OverridesDefaultStyle . 62   �� 54   
    � ��# �   6'   �� 55   
    � ��# �  6%   �� 56   
    � �� �#2121216'   �� 57   
    � �� 58      �� 59      " ��6"   .R�5:      � $
 TabItemRoot��6   $
��Auto��5;      $
��Auto��5<      $��5,0,0,0q�5=      ���#dadada.+�5?      �� $ Border��6!   $ 	10,5,10,5q�5@   !   ���#aaaaaa$��1,1,1,0q�5B   !   ._�5C      �� $ 
Horizontal=�6)   .+�5D   "   �� ��6,   �� *Content.DataContext.TabHeader+�� 5E   "   $��X��6)   $��5,0,0,0q�5F   )   y�5G   )   �� *%#Content.DataContext.ShowCloseButton+8    5H   &     5I   *   $ Click��6:   . 5J   .     5K   +   5M   #   5N      5O      5P       5Q      P� 5R       �@��
IsSelected . . �5S      �� $ Border��6%    � ��$ 0,0,0,-1q�6K   �� 5T      $ Border��6%    � �� �#ffffff6O   �� 5U      $ Border��6%    � �� �#aaaaaa6P   5V      5X      5Z      5[      5]      