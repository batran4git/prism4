   M S B A M L   `   `   `  ����T  PModularityWithMef.Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ModularityWithMef.DesktopModularityWithMef.Desktop  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35h dMicrosoft.Expression.Interactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35 3  /ModuleControl.NotStarted.BackgroundBrush-Simple  �� Color / +ModuleControl.NotStarted.BorderBrush-Simple 3 /ModuleControl.NotStarted.ForegroundBrush-Simple 4 0ModuleControl.Downloading.BackgroundBrush-Simple 0 ,ModuleControl.Downloading.BorderBrush-Simple 4 0ModuleControl.Downloading.ForegroundBrush-Simple 3 /ModuleControl.Downloaded.BackgroundBrush-Simple �� EndPoint �� 
StartPoint � Color � Offset / +ModuleControl.Downloaded.BorderBrush-Simple 3 /ModuleControl.Downloaded.ForegroundBrush-Simple 4	 0ModuleControl.Constructed.BackgroundBrush-Simple 0
 ,ModuleControl.Constructed.BorderBrush-Simple 4 0ModuleControl.Constructed.ForegroundBrush-Simple 4 0ModuleControl.Initialized.BackgroundBrush-Simple 0 ,ModuleControl.Initialized.BorderBrush-Simple 4 0ModuleControl.Initialized.ForegroundBrush-Simple   ModuleControlTemplate-Simple �� 
TargetType-    'ModularityWithMef.Desktop.ModuleControl ��Name �� Padding.  (System.Windows.Interactivity.Interaction   Triggers9  3Microsoft.Expression.Interactivity.Core.DataTrigger	   ValueD  >Microsoft.Expression.Interactivity.Core.PropertyChangedTrigger
   Binding �� ElementName �� Path.  (System.Windows.Interactivity.TriggerBase   ActionsB  <Microsoft.Expression.Interactivity.Core.ChangePropertyAction   PropertyName   Value8  2System.Windows.Interactivity.TargetedTriggerAction   TargetObject �� RelativeSource ��Name J� RenderTransformOrigin ��Name  ModuleControlStyle-Simple �� 
TargetType �� Property �� Value�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      Bei9http://schemas.microsoft.com/expression/2010/interactions  5      =ModularityWithMef'clr-namespace:ModularityWithMef.Desktop  5      %�  &	        &	      &	 =     &	 [     &	 z     &	 �     &	 �     &	 W    &	 z    &		 �    &	
 �    &	 �    &	 �    &	 �    &	 �    &	 �    7   7  7  7  7  7  7  7  7  7 	 7  7 
 7  7  7  &	 �    7   7  7  7  �� 5      $  White��6N   �� 5	      $
  Gray��6J   �� 5
      $
  Gray��6N   �� 5      $  White��6O   �� 5      $  	LightBlue��6K   �� 5      $  Black��6O   �� 5      $ 0.5,1&�6R   $ 0.5,0&�6c   .��5   
   � $ White��6   $
 0.02Q�6%   � 5   
   $ 	LightBlue��6   $ 1Q�6)   5      �� 5      $  	LightBlue��6J   �� 5      $  Black��6N   �� 5      $  White��6O   �� 5      $  Black��6K   �� 5      $  Black��6O   �� 5      $ 0.5,1&�6S   $ 0.5,0&�6d   .��5   
   � $ 	#FFBCE4A5��6   $
 0.02Q�6)   � 5   
   $ 	#FF579D2F��6   $ 1Q�6)   5      �� 5      $  	#FF36621D��6K   �� 5       $  Black��6O   �� 5"      "   6;   .R�5#   
   �� $ border��6   #��z��6!   #��z��6M   #��z��6�   # z��6�    5$        5(      $	 
NotStarted��6b   
 6!   �� $ ModuleStatusTextBlock��$
 Text�. 5)        $ 
Background��6.   8    6H   ��  �� *TemplatedParent+6�     5*      $ 
Foreground��6.   8   6H   ��  �� *TemplatedParent+6�     5+      $ BorderBrush��6.   8   6I   ��  �� *TemplatedParent+6�     5,      $ FontSize��6.   $ 12��6�    6F   ��  �� *TemplatedParent+6�   5-        5.      $	 Downloading��6b   
 6!   �� $ ModuleStatusTextBlock��$
 Text�. 5/        $ 
Background��6.   8   6H   ��  �� *TemplatedParent+6�     50      $ 
Foreground��6.   8   6H   ��  �� *TemplatedParent+6�     51      $ BorderBrush��6.   8   6I   ��  �� *TemplatedParent+6�   52        53      $	 
Downloaded��6b   
 6!   �� $ ModuleStatusTextBlock��$
 Text�. 54        $ 
Background��6.   8   6H   ��  �� *TemplatedParent+6�     55      $ 
Foreground��6.   8   6H   ��  �� *TemplatedParent+6�     56      $ BorderBrush��6.   8   6I   ��  �� *TemplatedParent+6�   57        58      $	 Constructed��6b   
 6!   �� $ ModuleStatusTextBlock��$
 Text�. 59        $ 
Background��6.   8 	  6H   ��  �� *TemplatedParent+6�     5:      $ 
Foreground��6.   8 
  6H   ��  �� *TemplatedParent+6�     5;      $ BorderBrush��6.   8   6I   ��  �� *TemplatedParent+6�     5<      $ FontSize��6.   $ 12��6�    6F   ��  �� *TemplatedParent+6�   5=        5>      $	 Initialized��6b   
 6!   �� $ ModuleStatusTextBlock��$
 Text�. 5?        $ 
Background��6.   8   6H   ��  �� *TemplatedParent+6�     5@      $ 
Foreground��6.   8   6H   ��  �� *TemplatedParent+6�     5A      $ BorderBrush��6.   8   6I   ��  �� *TemplatedParent+6�     5B      $ FontSize��6.   $ 15��6�    6F   ��  �� *TemplatedParent+6�   5C      ._�5E      � .+�5F      �� $ contentPresenter��6#   #��z��6=   #��z��6q   #��z��6�   #��z��6�   $ 0.5,0.5&�6  �� 5H      $ ModuleStatusTextBlock��63   $y�	Collapsed=�6   ��6R   ��  �� *TemplatedParent+$, &DataContext.ModuleInitializationStatus�5I      5J      5K      �� 5M      "   6.   .�5N   
   ��  � ��8   6'   �� 5O   
    � ��8  6'   �� 5P   
    � ��8  6(   �� 5Q   
    � ��$ 1q�6,   �� 5R   
    � ��8  6%   5S      5U      