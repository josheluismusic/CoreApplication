   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   MenuFontFamily  MenuFontSizeTopLevel  MenuFontSizeSubmenu  MenuBackgroundColor  MenuForegroundColor  MenuHoverBackgroundColor  MenuHoverForegroundColor  MenuScrollButton  �� 
TargetType �� BasedOn �� Property �� Value �� 
TargetType �� Padding ��Name $  MenuScrollingVisibilityConverter 	 	DownArrow 
 UpArrow  
RightArrow  MenuScrollViewer � RowDefinitions �� LineUpCommand	 �� RelativeSource
 �� FallbackValue `� 	Converter `� ConverterParameter �� Path �� LineDownCommand  MenuTopLevelHeaderTemplate ��Name � ColumnDefinitions F�Name J� Opacity �Name � HorizontalOffset � VerticalOffset m� IsSubmenuOpen � AllowsTransparency K� IsItemsHost-   'System.Windows.Input.KeyboardNavigation    DirectionalNavigation �� Triggers P� Property P� Value �� 
TargetName $  MenuButtonTopLevelHeaderTemplate  MenuTopLevelItemTemplate " MenuButtonTopLevelItemTemplate  MenuSubmenuHeaderTemplate P� 
SourceName # MenuSearchSubmenuHeaderTemplate  SubmenuItemTemplate  MenuItemStyle �� Triggers  MenuButtonItemStyle  	MenuStyle  J� SnapsToDevicePixels  MenuButtonStyle�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      1system&clr-namespace:System;assembly=mscorlib  5      %B&  &	        &	 %     &	 ?     &	 Y     &	 x     &	 �     &	 �     &	 �     &	 d    &		 w    &	
 �    &	 �    &	 �    7  7  7 
 7  7  7 	 &	 [	    7 	 7  &	     7 	 7  &	 ]    &	 &    &	 �    7  7  &	 )    7  &	 �    'm� T    &	 [    7m�&	 S!    7m�&	 K#    7   &	 �$    7  *�5      Titillium Web)�67   X�5      18Q�65   X�5      16Q�64   ��5	      #C0C0C0��6;   ��5
      #000000��6;   ��5      #000000��6@   ��5      #FFFFFF��6@   �� 5      "  ��5       5      Z� .�5   
   ��  �@��	ClickMode$ Hover=�6&   �� 5   
    � ��$ 0��6%   �� 5   
    � ��$ 0��6&   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� $ 10q�6   #���  5      ._�5      �� $ ContentContainer��6+   $��Center=�5   +   $��Center=�5   +   5      5      5       5!      l� 5#      6'   �5$      M 0,0 L 3.5,4 L 7,0 Z�68   �5%      M 0,4 L 3.5,0 L 7,4 Z�66   �5&      M 0,0 L 4,3.5 L 0,7 Z�69   �� 5)      "  ��5*       5+      Z� .�5,   
   ��  � ��$ Hidden=�6:   �� 5-   
    � ��$
 Auto=�68   �� 5.   
    � �� 5/      �� 50      " ��6"   .R�51      �  52      �� 53      $
��Auto �6,   �� 54      $��* �6,   �� 55      $
��Auto �6,   .+�57      �� $��1��61   �� 58      8��  $��0��59   '   #��Z 5:   '   |�.  ��5;   '   �� 	 �� *TemplatedParent+y�5=      `� 5>   "   $
 Visibility.Collapsed��6/   8  $ 0��5@   /   .1�5A   &   �� $) #ComputedVerticalScrollBarVisibility�5B   .   	 5A   .   �� *TemplatedParent+5B   .   �� 5C   &   $ VerticalOffset�5D   .   	 5C   .   �� *TemplatedParent+5D   .   �� 5E   &   $ ExtentHeight�5F   .   	 5E   .   �� *TemplatedParent+5F   .   �� 5G   &   $ ViewportHeight�5H   .   	 5G   .   �� *TemplatedParent+5H   .   5I   #   .��5K      F� 8�� #���  5L   #   5M      �� 5N      8�� $��2��5O   '   #��Z 5P   '   |�.  ��5Q   '   �� 	 �� *TemplatedParent+y�5S      `� 5T   "   $
 Visibility.Collapsed��6/   8  $	 100��5V   /   .1�5W   &   �� $) #ComputedVerticalScrollBarVisibility�5X   .   	 5W   .   �� *TemplatedParent+5X   .   �� 5Y   &   $ VerticalOffset�5Z   .   	 5Y   .   �� *TemplatedParent+5Z   .   �� 5[   &   $ ExtentHeight�5\   .   	 5[   .   �� *TemplatedParent+5\   .   �� 5]   &   $ ViewportHeight�5^   .   	 5]   .   �� *TemplatedParent+5^   .   5_   #   .��5a      F� 8�� #���  5b   #   5c      5d      5e      5g      5h      �� 5k      " m�5l      .R�5m   
   �� $ Border��6   $ 10q�5n      #���  5o      ._�5p      �  5q      �� 5r      $��* �6'   �� 5s      $
��Auto �6'   .+�5u      �� $��0��6#   $��Center=�5v   #   $��Center=�5w   #   $��Header��5x   #   F� 5y      $ Arrow��6   $��1��5z      $��10,0,0,0q�5{      $��Center=�5|      $��Center=�5}      $	 0.5Q�5~      8��  #���  5�      � 5�      $ Popup��6   $��Bottom=�5�      $	 -10��5�      $ 10��5�      #��z 5�       . |�.  $
��Fade=�5�      .��5�      �� ��. 8�� .��5�      ��  . $ Cycle=�5�   %   5�      5�      5�      5�       5�   
   P� 5�       � {� . . �5�      �� # �  6/    � ���� 5�      # �  6-    � ��5�      P� 5�       �@m�IsHighlighted . . �5�      �� # �  6/    � ���� 5�      $ Border��6   # �  6C    � ���� 5�      $ Arrow��6    �@J�Opacity$ 1Q�6?   �� 5�      $ Arrow��6   # �  6<    � ��5�      P� 5�      " �@m�IsSuspendingPopupAnimation . . �5�      �� $ Popup��6    � ��$
 None=�6F   5�      5�      �� 5�      " m�5�      .R�5�   
   �� $ Border��6   $ 5q�5�      ._�5�      �  5�      �� 5�      $
��Auto �6'   �� 5�      $
��Auto �6'   .+�5�      �� $
��Icon��6#   $��38��5�   #   $��38��5�   #   F� 5�      $ Arrow��6   $��1��5�      $��5,0,0,0q�5�      $��Center=�5�      $��Center=�5�      $	 0.5Q�5�      8��  #���  5�      � 5�      $ Popup��6   $��Bottom=�5�      $ -5��5�      $ 5��5�      #��z 5�       . |�.  $
��Fade=�5�      .��5�      �� ��. 8�� .��5�      ��  . $ Cycle=�5�   %   5�      5�      5�      5�       5�   
   P� 5�       � {� . . �5�      �� # �  6/    � ��5�      P� 5�       �@m�IsHighlighted . . �5�      �� # �  6/    � ���� 5�      $ Border��6   # �  6C    � ���� 5�      $ Arrow��6    �@J�Opacity$ 1Q�6?   �� 5�      $ Arrow��6   # �  6<    � ��5�      P� 5�      " �@m�IsSuspendingPopupAnimation . . �5�      �� $ Popup��6    � ��$
 None=�6F   5�      5�      �� 5�      " m�5�      .R�5�   
   �� $ Border��6   $ 10q�5�      #���  5�      ._�5�      �� $��Header��6   $��Center=�5�      $��Center=�5�      5�       5�   
   P� 5�       � {� . . �5�      �� # �  6/    � ���� 5�      # �  6-    � ��5�      P� 5�       �@m�IsHighlighted . . �5�      �� # �  6/    � ���� 5�      $ Border��6   # �  6C    � ��5�      5�      �� 5�      " m�5�      .R�5�   
   �� $ Border��6   $ 5q�5�      #���  5�      ._�5�      �� $
��Icon��6   $��38��5�      $��38��5�      5�       5�   
   P� 5�       � {� . . �5�      �� # �  6/    � ��5�      P� 5�       �@m�IsHighlighted . . �5�      �� # �  6/    � ���� 5�      $ Border��6   # �  6C    � ��5�      5�      �� 5     " m�5     .R�5  
   �� $ Border��6   $ 0,2,0,2q�5     #���  5     ._�5     �  5     �� 5     $��20 �6'   �� 5	     $��* �6'   �� 5
     $��20 �6'   .+�5     �� $��1��6   $ 5,0,5,0q�5     ._�5     �� $��Header��6'   5     F� 5     $ Arrow��6   $��2��5     $��Center=�5     $��Center=�5     $	 0.5Q�5     8��  #���  5     � 5     $ Popup��6   $��Right=�5     $ -2��5     #��z 5      . |�.  $
��Fade=�5     .��5     �� ��. 8�� .��5      ��  . $ Cycle=�5!  %   5"     5#     5$     5%      5&  
   P� 5'      � {� . . �5(     �� # �  6/    � ���� 5)     # �  6-    � ��5*     P� 5+      �@m�IsHighlighted . . �5,     �� # �  6/    � ���� 5-     $ Border��6   # �  6C    � ���� 5.     $ Arrow��6    �@J�Opacity$ 1Q�6?   �� 5/     $ Arrow��6   # �  6<    � ��50     P� 51     $ Popup��6    �@�AllowsTransparency . 6G   53     �� 55     " m�56     .R�57  
   �� $ Border��6   $ 5q�58     #���  59     ._�5:     � .+�5;     �� $��Header��6#   � 5<     $ Popup��6   $��Bottom=�5=     $ 5��5>     $ -5��5?     #��z 5@      . |�.  $
��Fade=�5C     .��5D     �� ��. $	��210��5E  #   8��  .��5G     ��  . $ Cycle=�5H  %   5I     5J     5K     5L     5M     5N     �� 5Q     " m�5R     .R�5S  
   �� $ Border��6   $ 0,2,0,2q�5T     #���  5U     ._�5V     �  5W     �� 5X     $��20 �6'   �� 5Y     $��* �6'   �� 5Z     $��20 �6'   .+�5\     �� $��1��6   $ 5,0,5,0q�6)   ._�5]     �� $��Header��6'   5^     5_     5`      5a  
   P� 5b      64   Z�  � ��P� 5c      � {� . . �5d     �� # �  6/    � ���� 5e     # �  6-    � ��5f     P� 5g      �@m�IsHighlighted . . �5h     �� # �  6/    � ���� 5i     $ Border��6/   # �  6C    � ��5j     5l     �� 5o     "  m�5p     .�5q  
   ��  � �� 6#   �� *Title+�� 5r  
    � �� 6(   �� *SubMenuItems+�� 5s  
    �@m�Command 6$   �� *	Command+�� 5t  
    �@m�CommandParameter 6-   �� *
CommandArg+5u     �� 5w     "  m�5x     8   .�5z  
   ��  �@�OverridesDefaultStyle . 62    5{  
   P� 5|      �@m�Role$ TopLevelHeader=�6&   . �5}     ��  � ��# �  6-   5~     P� 5      �@m�Role$ TopLevelItem=�6&   . �5�     ��  � ��# �  6-   5�     P� 5�      �@m�Role$ SubmenuHeader=�6&   . �5�     ��  � ��# �  6-   5�     P� 5�      �@m�Role$ SubmenuItem=�6&   . �5�     ��  � ��# �  6-   5�     5�     �� 5�     "  m�5�     8   .�5�  
   ��  �@�OverridesDefaultStyle . 62    5�  
   P� 5�      �@m�Role$ TopLevelHeader=�6&   . �5�     ��  � ��# �  6-   5�     P� 5�      �@m�Role$ TopLevelItem=�6&   . �5�     ��  � ��# �  6-   5�     P� 5�      �@m�Role$ SubmenuHeader=�6&   . �5�     ��  � ��# �  6-   5�     P� 5�      �@m�Role$ SubmenuItem=�6&   . �5�     ��  � ��# �  6-   5�     5�     �� 5�     "  o�5�     .�5�  
   ��  �@�OverridesDefaultStyle . 62   �� 5�  
    �@J�SnapsToDevicePixels . 60   �� 5�  
    � ��8   6'   �� 5�  
    � ��$ Center=�6.   �� 5�  
    � �� 5�     �� 5�     " o�6"   .R�5�     ��   . 6%   5�     5�     �� 5�  
    � ��# �  6/   5�     �� 5�     "  o�5�     8   .�5�  
   ��  � ��# �  6/   5�     5�     