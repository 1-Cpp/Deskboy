����~   h t t p s : / / m s d n . m i c r o s o f t . c o m / e n - u s / l i b r a r y / m s 6 4 6 3 0 9 ( v = v s . 8 5 ) . a s p x ��������~   h t t p s : / / m s d n . m i c r o s o f t . c o m / e n - u s / l i b r a r y / m s 6 4 6 3 0 9 ( v = v s . 8 5 ) . a s p x ��������~   h t t p s : / / m s d n . m i c r o s o f t . c o m / e n - u s / l i b r a r y / m s 6 4 6 3 0 9 ( v = v s . 8 5 ) . a s p x ��������~   h t t p s : / / m s d n . m i c r o s o f t . c o m / e n - u s / l i b r a r y / m s 6 4 6 3 0 9 ( v = v s . 8 5 ) . a s p x ��������   r e g i s t e r e d ��������   M O D _ N O R E P E A T   ��������~   	 	   R e g i s t e r H o t K e y ( h W n d ,   1 ,   M O D _ C O N T R O L   |   M O D _ A L T , V K _ R E T U R N   ) ;  
 ��������~   	 	   R e g i s t e r H o t K e y ( h W n d ,   1 ,   M O D _ C O N T R O L   |   M O D _ A L T , V K _ R E T U R N   ) ;  
 ��������   G H N D ��������   i g n o r e   =   ��������   i g n o r e   =   ��������~   h t t p s : / / m s d n . m i c r o s o f t . c o m / e n - u s / l i b r a r y / m s 6 4 6 3 0 9 ( v = v s . 8 5 ) . a s p x ��������$   S e t C l i p b o a r d V i e w e r ��������B   	 	 	 	   S h o w W i n d o w ( h W n d ,   S W _ S H O W ) ;  
 ��������~   h t t p s : / / m s d n . m i c r o s o f t . c o m / e n - u s / l i b r a r y / m s 6 4 6 3 0 9 ( v = v s . 8 5 ) . a s p x ��������   R e g i s t e r H o t K e y ��������   R e g i s t e r H o t K e y ��������N   	 	 	 	 	 	 v o i d   *   p   =   G l o b a l L o c k ( h G l o b a l ) ;  
 ��������    S e t C l i p b o a r d D a t a ��������   L B N _ S E L C H A N G E ��������   L B N _ S E L C H A N G E ��������   a k t i v i e r t e s ��������   m i c r o s o f t ��������    S e t W i n d o w s H o o k E x ��������    S e t W i n d o w s H o o k E x ��������   m i c r o s o f t ��������   a k t i o n e n ��������   m i c r o s o f t ��������   m i c r o s o f t ��������   a k t i o n e n ��������   l i b r a r y ��������    W M _ D R A W C L I P B O A R D ��������    W M _ D R A W C L I P B O A R D ��������   p r o g r a m m ��������   m i c r o s o f t ��������$   S e t C l i p b o a r d V i e w e r ��������   m s d n ��������   H I W O R D ( w P a r a m ) ��������   m i t s c h n e i d e n ��������   l i b r a r y ��������    W M _ D R A W C L I P B O A R D ��������    W M _ D R A W C L I P B O A R D ��������   u n i c o d e ��������   v e r a r b e i t e n ��������   v e r a r b e i t e n ��������   a k t i v i e r t e s ��������   l i b r a r y ��������   m i t s c h n e i d e n ��������   m i c r o s o f t ���������   	 	 	 	 	 s w i t c h   ( h i g h )  
 	 	 	 	 	 {  
 	 	 	 	 	 c a s e   L B N _ D B L C L K :  
 	 	 	 	 	 c a s e   L B N _ S E L C H A N G E :  
 ��������(   C h a n g e C l i p b o a r d C h a i n ��������   P o s t Q u i t M e s s a g e ��������    W M _ D R A W C L I P B O A R D ��������x  	 	 	 	 	 	 i n d e x   =   S e n d M e s s a g e ( h L i s t ,   L B _ G E T C U R S E L ,   0 ,   0 ) ;  
 	 	 	 	 	 	 i f   ( i n d e x   > =   0   & &   i n d e x   <   ( i n t )   b u f f e r . s i z e ( ) )  
 	 	 	 	 	 	 {  
 	 	 	 	 	 	 	 c u r r e n t   =   b u f f e r [ i n d e x ] ;  
 	 	 	 	 	 	 	 H G L O B A L   h G l o b a l   =   G l o b a l A l l o c ( G H N D ,   ( c u r r e n t . s i z e ( )   +   1 )   < <   1 ) ;  
 	 	 	 	 	 	 	 v o i d   *   p   =   G l o b a l L o c k ( h G l o b a l ) ;  
 	 	 	 	 	 	 	 w m e m c p y ( ( w c h a r _ t * ) p ,   c u r r e n t . c _ s t r ( ) ,   c u r r e n t . s i z e ( )   +   1 ) ;  
 	 	 	 	 	 	 	 G l o b a l U n l o c k ( h G l o b a l ) ;  
 	 	 	 	 	 	 	 i g n o r e   =   t r u e ;  
 	 	 	 	 	 	 	 S e t C l i p b o a r d D a t a ( C F _ U N I C O D E T E X T ,   h G l o b a l ) ;  
 	 	 	 	 	 	 }  
 ��������   S e t A u t o V i e w ��������   S e n d M e s s a g e ��������   h w n d N e x t V i e w e r ��������(   C h a n g e C l i p b o a r d C h a i n ��������   h w n d N e x t V i e w e r ��������   S e n d M e s s a g e ��������   h w n d N e x t V i e w e r ��������(   C h a n g e C l i p b o a r d C h a i n ��������   m e s s a g e ��������<   	 	 	 	 	 	 G l o b a l U n l o c k ( h G l o b a l ) ;  
 ��������<   	 	 	 	 	 	 G l o b a l U n l o c k ( h G l o b a l ) ;  
 ��������    W M _ D R A W C L I P B O A R D ��������   S e t A u t o V i e w ��������   h w n d N e x t V i e w e r ��������   L B _ G E T C U R S E L ��������r   	 	 	   S e n d M e s s a g e ( h L i s t ,   L B _ A D D S T R I N G ,   0 ,   ( L P A R A M ) l p s t r ) ;  
 ��������    
 ��������    
 ��������   S e t A u t o V i e w ��������    W M _ D R A W C L I P B O A R D ��������(   C h a n g e C l i p b o a r d C h a i n ��������   h w n d N e x t V i e w e r ��������8   h w n d N e x t V i e w e r h w n d N e x t V i e w e r ��������D   h w n d N e x t V i e w e r C h a n g e C l i p b o a r d C h a i n ��������8   h w n d N e x t V i e w e r h w n d N e x t V i e w e r ��������$   m e s s a g e S e n d M e s s a g e ��������    W M _ D R A W C L I P B O A R D ��������   S e t A u t o V i e w ��������   S e n d M e s s a g e ��������   h w n d N e x t V i e w e r ��������(   C h a n g e C l i p b o a r d C h a i n ��������   h w n d N e x t V i e w e r ��������   S e n d M e s s a g e ��������   W M _ D E S T R O Y ��������T   
               c a s e   W M _ D R A W C L I P B O A R D :     / /   c l i p b o a r d   c o n t e n t s   c h a n g e d .    
    
                         / /   U p d a t e   t h e   w i n d o w   b y   u s i n g   A u t o   c l i p b o a r d   f o r m a t .    
    
                         S e t A u t o V i e w ( h w n d ) ;    
    
                         / /   P a s s   t h e   m e s s a g e   t o   t h e   n e x t   w i n d o w   i n   c l i p b o a r d    
                         / /   v i e w e r   c h a i n .    
    
                         S e n d M e s s a g e ����