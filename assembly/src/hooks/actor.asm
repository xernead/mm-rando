;==================================================================================================
; Actor Hooks
;==================================================================================================

.headersize (G_CODE_RAM - G_CODE_FILE)

; Replaced:
;   jalr    ra, v0
;   sw      a0, 0x0018 (sp)
;   lw      a0, 0x0018 (sp)
;   sw      r0, 0x0134 (a0)
.org 0x800B6968
    sw      a0, 0x0018 (sp)
    jal     actor_after_dtor_hook
    sw      a1, 0x001C (sp)
    nop
